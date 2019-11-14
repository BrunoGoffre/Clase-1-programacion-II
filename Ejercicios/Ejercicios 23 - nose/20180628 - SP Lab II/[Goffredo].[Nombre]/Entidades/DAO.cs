using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class DAO : IArchivos<Votacion>
    {
        public Votacion Leer(string msj)
        {
            throw new NotImplementedException();
        }
        public bool Guardar(string msj, Votacion t)
        {

            String conexcionStr = "Data Source=.\\SQLEXPRESS;" +
                "Initial Catalog =votacion-sp-2018.bak; Integrated Security = True";

            SqlConnection conexion = new SqlConnection(conexcionStr);

            SqlCommand comando;

            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;

            comando.Connection = conexion;

            comando.CommandText = "INSERT  FROM Personas";
            try
            {
                conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    string aux = oDr["dbo.Voaciones"].ToString();
                }

            }
            catch (Exception e)
            {

            }


            return true;






        }
    }
}
