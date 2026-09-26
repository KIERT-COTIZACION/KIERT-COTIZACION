using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Datos
{
    public static class Repositorio
    {
        // ================= CLIENTES =================
        public static List<Cliente> ObtenerClientes()
        {
            var lista = new List<Cliente>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT Id, Nombre, Documento, Telefono, Email, Direccion FROM Clientes ORDER BY Nombre", conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lista.Add(new Cliente
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Nombre = r["Nombre"]?.ToString(),
                            Documento = r["Documento"]?.ToString(),
                            Telefono = r["Telefono"]?.ToString(),
                            Email = r["Email"]?.ToString(),
                            Direccion = r["Direccion"]?.ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public static int InsertarCliente(Cliente c)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"INSERT INTO Clientes (Nombre, Documento, Telefono, Email, Direccion)
                             VALUES (@n,@d,@t,@e,@dir); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@n", c.Nombre ?? "");
                    cmd.Parameters.AddWithValue("@d", (object)c.Documento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)c.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)c.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@dir", (object)c.Direccion ?? DBNull.Value);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public static void ActualizarCliente(Cliente c)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"UPDATE Clientes SET Nombre=@n, Documento=@d, Telefono=@t, Email=@e, Direccion=@dir WHERE Id=@id";
                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    cmd.Parameters.AddWithValue("@n", c.Nombre ?? "");
                    cmd.Parameters.AddWithValue("@d", (object)c.Documento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)c.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)c.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@dir", (object)c.Direccion ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarCliente(int id)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Clientes WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ================= PRODUCTOS =================
        public static List<Producto> ObtenerProductos()
        {
            var lista = new List<Producto>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT Id, Codigo, Descripcion, Precio, Stock FROM Productos ORDER BY Codigo", conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lista.Add(new Producto
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Codigo = r["Codigo"]?.ToString(),
                            Descripcion = r["Descripcion"]?.ToString(),
                            Precio = r["Precio"] != DBNull.Value ? Convert.ToDecimal(r["Precio"]) : 0,
                            Stock = r["Stock"] != DBNull.Value ? Convert.ToInt32(r["Stock"]) : 0
                        });
                    }
                }
            }
            return lista;
        }

        public static int InsertarProducto(Producto p)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"INSERT INTO Productos (Codigo, Descripcion, Precio, Stock)
                             VALUES (@c,@d,@p,@s); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@c", p.Codigo ?? "");
                    cmd.Parameters.AddWithValue("@d", p.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@p", p.Precio);
                    cmd.Parameters.AddWithValue("@s", p.Stock);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public static void ActualizarProducto(Producto p)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"UPDATE Productos SET Codigo=@c, Descripcion=@d, Precio=@p, Stock=@s WHERE Id=@id";
                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cmd.Parameters.AddWithValue("@c", p.Codigo ?? "");
                    cmd.Parameters.AddWithValue("@d", p.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@p", p.Precio);
                    cmd.Parameters.AddWithValue("@s", p.Stock);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarProducto(int id)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                using (var cmd = new SqlCommand("DELETE FROM Inventario WHERE ProductoId=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SqlCommand("DELETE FROM Productos WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ================= INVENTARIO =================
        public static List<InventarioItem> ObtenerInventarioPorProducto(int productoId)
        {
            var lista = new List<InventarioItem>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT Id, ProductoId, Talla, Color, Cantidad FROM Inventario WHERE ProductoId=@p ORDER BY Talla, Color", conn))
                {
                    cmd.Parameters.AddWithValue("@p", productoId);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new InventarioItem
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                ProductoId = Convert.ToInt32(r["ProductoId"]),
                                Talla = r["Talla"]?.ToString(),
                                Color = r["Color"]?.ToString(),
                                Cantidad = r["Cantidad"] != DBNull.Value ? Convert.ToInt32(r["Cantidad"]) : 0
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public static InventarioItem ObtenerInventarioPorId(int id)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT Id, ProductoId, Talla, Color, Cantidad FROM Inventario WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new InventarioItem
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                ProductoId = Convert.ToInt32(r["ProductoId"]),
                                Talla = r["Talla"]?.ToString(),
                                Color = r["Color"]?.ToString(),
                                Cantidad = r["Cantidad"] != DBNull.Value ? Convert.ToInt32(r["Cantidad"]) : 0
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static void InsertarInventario(int productoId, string talla, string color, int cantidad)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "INSERT INTO Inventario (ProductoId, Talla, Color, Cantidad) VALUES (@p, @t, @c, @q)", conn))
                {
                    cmd.Parameters.AddWithValue("@p", productoId);
                    cmd.Parameters.AddWithValue("@t", (object)talla ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", (object)color ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@q", cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ActualizarTallaColor(int id, string talla, string color)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"UPDATE Inventario SET Talla = @talla, Color = @color WHERE Id = @id";
                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@talla", (object)talla ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@color", (object)color ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ActualizarInventarioCompleto(int id, string talla, string color, int cantidad)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"UPDATE Inventario SET Talla = @talla, Color = @color, Cantidad = @cantidad WHERE Id = @id";
                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@talla", (object)talla ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@color", (object)color ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarInventario(int id)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Inventario WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ObtenerStockTotalProducto(int productoId)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Cantidad),0) FROM Inventario WHERE ProductoId=@p", conn))
                {
                    cmd.Parameters.AddWithValue("@p", productoId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static void ActualizarStockProducto(int productoId, int stockTotal)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Productos SET Stock=@s WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@s", stockTotal);
                    cmd.Parameters.AddWithValue("@id", productoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}