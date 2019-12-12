using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pruebas_de_SQl
{
    public class Class1
    {
        SqlConnection connection;
        SqlCommand command;

        public Class1()
        {
            string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017; Integrated Security=True";
            connection = new SqlConnection(connectionStr);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public List<Class2> MethodSql(List<Class2> entregas)
        {
            command.CommandText = "SELECT id,direccionEntrega FROM dbo.Paquetes";
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int numero;
                    int.TryParse(reader["id"].ToString(), out numero);
                    entregas.Add(new Class2(numero,reader["direccionEntrega"].ToString()));
                }

                return entregas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static string NuevoMEtodo()
        {
            string hola = "nada";
            return hola.StringMethod(2);
        }
        public static int OtroMetodo()
        {
            int hola = 5;
            return hola.IntMethod(5);
        }
    }
}
