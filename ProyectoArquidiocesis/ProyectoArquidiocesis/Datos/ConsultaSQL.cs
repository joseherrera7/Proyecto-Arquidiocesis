using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArquidiocesis.Datos
{
    class ConsultaSQL
    {
        public void NuevoMatrimonio(string id, string fecha, string notario, string novio, string novia, string urlDoc, string hashcode)
        {
            //crear un objeto conexion
            MySqlConnection conectar = Conexion.getConexion();

            try
            {
                //Abrir conexion
                conectar.Open();

                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Enviar la cadena conexión
                comando.Connection = conectar;


                //Pondremos tipo text y enviar sql
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "INSERT INTO MATRIMONIO VALUES(@a, @b, @c, @d, @e, @f, @g);";

                //Agregar los parametros
                comando.Parameters.AddWithValue("@a", id);
                comando.Parameters.AddWithValue("@b", fecha);
                comando.Parameters.AddWithValue("@c", notario);
                comando.Parameters.AddWithValue("@d", novio);
                comando.Parameters.AddWithValue("@e", novia);
                comando.Parameters.AddWithValue("@f", urlDoc);
                comando.Parameters.AddWithValue("@g", hashcode);

                //Ejecutar comando sql
                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Entro catch1");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        public void NuevoBautismo(string id, string fecha, string notario, string bautizado, string urlDoc, string hashcode)
        {
            //crear un objeto conexion
            MySqlConnection conectar = Conexion.getConexion();

            try
            {
                //Abrir conexion
                conectar.Open();

                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Enviar la cadena conexión
                comando.Connection = conectar;


                //Pondremos tipo text y enviar sql
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "INSERT INTO CONFIRMACION VALUES(@a, @b, @c, @d, @e, @f);";

                //Agregar los parametros
                comando.Parameters.AddWithValue("@a", id);
                comando.Parameters.AddWithValue("@b", fecha);
                comando.Parameters.AddWithValue("@c", notario);
                comando.Parameters.AddWithValue("@d", bautizado);
                comando.Parameters.AddWithValue("@e", urlDoc);
                comando.Parameters.AddWithValue("@f", hashcode);

                //Ejecutar comando sql
                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Entro catch1");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Entro catch2");
            }
        }

        public void NuevaConfirmacion(string id, string fecha, string notario, string confirmado, string urlDoc, string hashcode)
        {
            //crear un objeto conexion
            MySqlConnection conectar = Conexion.getConexion();

            try
            {
                //Abrir conexion
                conectar.Open();

                //crear objeto de tipo MySqlCommand
                MySqlCommand comando = new MySqlCommand();

                //Enviar la cadena conexión
                comando.Connection = conectar;


                //Pondremos tipo text y enviar sql
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "INSERT INTO CONFIRMACION VALUES(@a, @b, @c, @d, @e, @f);";

                //Agregar los parametros
                comando.Parameters.AddWithValue("@a", id);
                comando.Parameters.AddWithValue("@b", fecha);
                comando.Parameters.AddWithValue("@c", notario);
                comando.Parameters.AddWithValue("@d", confirmado);
                comando.Parameters.AddWithValue("@e", urlDoc);
                comando.Parameters.AddWithValue("@f", hashcode);

                //Ejecutar comando sql
                try
                {
                    comando.ExecuteNonQuery();
                    conectar.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Entro catch1");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Entro catch2");
            }
        }
    }
}
