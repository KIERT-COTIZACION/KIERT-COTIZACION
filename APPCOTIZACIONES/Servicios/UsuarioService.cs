using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Servicios
{
    public static class UsuarioService
    {
        /// <summary>
        /// Convierte una contraseña en su hash SHA256 (hexadecimal).
        /// </summary>
        public static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        /// <summary>
        /// Valida el login. Devuelve el Usuario o null si las credenciales son incorrectas.
        /// </summary>
        public static Usuario ValidarLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    string query = @"SELECT Id, Username, NombreCompleto, Rol
                                     FROM Usuarios
                                     WHERE Username = @u 
                                       AND PasswordHash = @p 
                                       AND Activo = 1";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username.Trim());
                        cmd.Parameters.AddWithValue("@p", HashPassword(password));

                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                return new Usuario
                                {
                                    Id = Convert.ToInt32(r["Id"]),
                                    Username = r["Username"].ToString(),
                                    NombreCompleto = r["NombreCompleto"]?.ToString(),
                                    Rol = r["Rol"]?.ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar login: " + ex.Message, ex);
            }
            return null;
        }

        /// <summary>
        /// Crea un nuevo usuario. Devuelve true si se creó, lanza excepción si ya existe.
        /// </summary>
        public static bool CrearUsuario(string username, string password,
            string nombreCompleto, string email, string rol = "vendedor")
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("El nombre de usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("La contraseña es obligatoria.");
            if (password.Length < 6)
                throw new Exception("La contraseña debe tener al menos 6 caracteres.");

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    // Verificar si ya existe
                    using (var check = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Username = @u", conn))
                    {
                        check.Parameters.AddWithValue("@u", username.Trim());
                        int existe = Convert.ToInt32(check.ExecuteScalar());
                        if (existe > 0)
                            throw new Exception("El nombre de usuario ya existe. Elija otro.");
                    }

                    // Insertar
                    string query = @"INSERT INTO Usuarios (Username, PasswordHash, NombreCompleto, Email, Rol, Activo)
                                     VALUES (@u, @p, @n, @e, @r, 1)";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username.Trim());
                        cmd.Parameters.AddWithValue("@p", HashPassword(password));
                        cmd.Parameters.AddWithValue("@n", (object)nombreCompleto ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@e", (object)email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@r", string.IsNullOrWhiteSpace(rol) ? "vendedor" : rol);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new Exception("El nombre de usuario ya existe. Elija otro.");
            }
        }

        /// <summary>
        /// Cuenta cuántos usuarios hay (para saber si es la primera vez).
        /// </summary>
        public static int ContarUsuarios()
        {
            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }
    }
}