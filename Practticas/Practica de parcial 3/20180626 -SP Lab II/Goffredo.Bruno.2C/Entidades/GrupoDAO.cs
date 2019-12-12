using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public class GrupoDAO
    {
        public static SqlConnection connection;
        public static SqlCommand command;


        public string Consulta
        {
            set
            {
                GrupoDAO.command.CommandText = value;
            }
        }

        static GrupoDAO()
        {
            string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=mundial-sp-2018; Integrated Security=True";

            GrupoDAO.connection = new SqlConnection(connectionStr);
            GrupoDAO.command = new SqlCommand();

            GrupoDAO.command.CommandType = System.Data.CommandType.Text;
            GrupoDAO.command.Connection = GrupoDAO.connection;
        }
       
        public GrupoDAO(string consulta)
        {
            GrupoDAO.command.CommandText = consulta;
        }
    }
}
