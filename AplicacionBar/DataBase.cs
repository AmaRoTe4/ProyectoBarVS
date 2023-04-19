using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBar
{
    public class DataBase
    {
        private SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PruebaUsuarios;Data Source=DESKTOP-7VB377L\\SQLEXPRESS");

        //classiicaciones
        public List<Clasificacion> ClassGetAll()
        {
                List<Clasificacion> clasificaciones = new List<Clasificacion>();
                try
                {
                    connection.Open();
                    string query = @"SELECT id, nombre FROM Clasificacion";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clasificaciones.Add(new Clasificacion
                        {
                            id = int.Parse(reader["id"].ToString()),
                            nombre = reader["nombre"].ToString(),
                        });
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            return clasificaciones;
        }

        public Clasificacion ClassGet(int id)
        {
            Clasificacion clasificacion = new Clasificacion();
            List<Clasificacion> clasificaciones = ClassGetAll();

            if (clasificaciones == null) return null;

            clasificaciones.ForEach(n =>
            {
                if (n.id == id)
                {
                    clasificacion = n;
                }
            });

            return clasificacion;
        }

        public bool ClassCreate(Clasificacion newClass)
        {
            try
            {
                //remplazar name , y ver dependencias
                connection.Open();
                string query = @"
                    INSERT INTO Clasificacion (nombre)
                    VALUES (@nombre)
                ";
                
                SqlParameter nombre = new SqlParameter("@nombre", newClass.nombre);
                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.Add(nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public bool ClassEdita(int id , Clasificacion newClass)
        {
            try
            {

                connection.Open();
                string query = @" UPDATE Clasificacion
                                  SET nombre = @nombre
                                  WHERE id = @id ";

                SqlParameter newId = new SqlParameter("@id", id);
                SqlParameter nombre = new SqlParameter("@nombre", newClass.nombre);
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(newId);
                command.Parameters.Add(nombre);
                
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

        public bool ClassRemove(int id)
        {
            try
            {

                connection.Open();
                string query = @" DELETE FROM Clasificacion WHERE id=@id ";

                SqlParameter newId = new SqlParameter("@id", id);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(newId);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }

            return true;

        }

        //productos
        public List<InterfaceProductos> ProductGetAll()
        {
            List<InterfaceProductos> Productos = new List<InterfaceProductos>();
            try
            {
                connection.Open();
                string query = @"SELECT id, nombre, clasificacion, precio FROM Productos";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Productos.Add(new InterfaceProductos
                    {
                        id = int.Parse(reader["id"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        precio = float.Parse((string)reader["precio"]),
                        clasificacion = Convert.ToInt32(reader["clasificacion"]),
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
            return Productos;
        }

        public InterfaceProductos ProductGet(int id)
        {
            InterfaceProductos producto = new InterfaceProductos();
            List<InterfaceProductos> productos = ProductGetAll();

            if (productos == null) return null;

            productos.ForEach(n =>
            {
                if (n.id == id)
                {
                    producto = n;
                }
            });
            return producto;
        }

        public bool ProductCreate(InterfaceProductos newProductos)
        {
            try
            {
                //remplazar name , y ver dependencias
                connection.Open();
                string query = @"
                    INSERT INTO Productos (nombre, clasificacion, precio)
                    VALUES (@nombre, @clasificacion, @precio)
                ";

                SqlParameter nombre = new SqlParameter("@nombre", newProductos.nombre);
                SqlParameter clasificacion = new SqlParameter("@clasificacion", newProductos.clasificacion);
                SqlParameter precio = new SqlParameter("@precio", newProductos.precio);
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(nombre);
                command.Parameters.Add(clasificacion);
                command.Parameters.Add(precio);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public bool ProductEdita(int id, InterfaceProductos newClass)
        {
            try
            {

                connection.Open();
                string query = @" UPDATE Productos
                                  SET nombre = @nombre,                                  
                                  precio = @precio,
                                  clasificacion = @clasificacion
                                  WHERE id = @id ";

                SqlParameter newId = new SqlParameter("@id", id);
                SqlParameter nombre = new SqlParameter("@nombre", newClass.nombre);
                SqlParameter precio = new SqlParameter("@precio", newClass.precio);
                SqlParameter clasificacion = new SqlParameter("@clasificacion", newClass.clasificacion);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(newId);
                command.Parameters.Add(nombre);
                command.Parameters.Add(precio);
                command.Parameters.Add(clasificacion);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

        public bool ProductRemove(int id)
        {
            try
            {

                connection.Open();
                string query = @" DELETE FROM Productos WHERE id=@id ";

                SqlParameter newId = new SqlParameter("@id", id);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(newId);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

        //mesas
        public InterfaceMesas MesasGet(int id)
        {
            connection.Open();
            InterfaceMesas mesa = new InterfaceMesas();
            string query = @"SELECT id, nombre, productos_vendidos FROM Mesas";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(id == int.Parse(reader["id"].ToString()))
                {
                    mesa.id = Convert.ToInt32(reader["id"].ToString()),
                    mesa.nombre = reader["nombre"].ToString(),
                    mesa.productos_vendidos = reader["productos_vendidos"].ToString(
                    break;
                }
            }

            if (mesa == null) return null;

            return mesa;
        }

        public bool MesasEdita(int id, InterfaceMesas newMesas)
        {
            try
            {
                connection.Open();
                string query = @" UPDATE Mesas
                                  SET nombre = @nombre,                                  
                                  productos_vendidos  = @productos_vendidos
                                  WHERE id = @id ";

                SqlParameter newId = new SqlParameter("@id", id);
                SqlParameter nombre = new SqlParameter("@nombre", newMesas.nombre);
                SqlParameter productos_vendidos = new SqlParameter("@productos_vendidos", newMesas.productos_vendidos);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(newId);
                command.Parameters.Add(nombre);
                command.Parameters.Add(productos_vendidos);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

        //VentasDiarias diarias
        public List<VentasDiarias> VentaDGetAll()
        {
            List<VentasDiarias> ventas = new List<VentasDiarias>();
            try
            {
                connection.Open();
                string query = @"SELECT id, nombre, clasificacion, precio FROM VentasDiarias";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ventas.Add(new VentasDiarias
                    {
                        id = int.Parse(reader["id"].ToString()),
                        fecha = DateTime.Parse((string)reader["fecha"]),
                        total = float.Parse((string)reader["total"]),
                        productos = reader["productos"].ToString(),
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
            return ventas;
        }


        public VentasDiarias VentaDGet(int id)
        {
            VentasDiarias venta = new VentasDiarias();
            List<VentasDiarias> ventas = VentaDGetAll();

            if (ventas == null) return null;

            ventas.ForEach(n =>
            {
                if (n.id == id)
                {
                    venta = n;
                }
            });
            return venta;
        }

        public bool VentaDCreate(VentasDiarias newVenta)
        {
            string fechaTexto = "19/04/2023 14:30:00";
            string formatoFecha = "dd/MM/yyyy HH:mm:ss";
            DateTime fechaNow = DateTime.ParseExact(fechaTexto, formatoFecha, CultureInfo.InvariantCulture);

            try
            {
                //remplazar name , y ver dependencias
                connection.Open();
                string query = @"
                    INSERT INTO VentasDiarias (fecha, total, productos)
                    VALUES (@fecha, @total, @productos)
                ";

                SqlParameter fecha = new SqlParameter("@fecha", fechaNow);
                SqlParameter total= new SqlParameter("@total", newVenta.total);
                SqlParameter productos = new SqlParameter("@productos", newVenta.productos);
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(fecha);
                command.Parameters.Add(total);
                command.Parameters.Add(productos);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
                //return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}
