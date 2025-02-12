using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GymFrm
{
    public class DbConnection
    {
        public static SqlConnection DbConnect()
        {
            var con = new SqlConnection();
            con.ConnectionString = @"Data Source=Aleena-44;Initial Catalog=gymManagemeent;Integrated Security=True;Encrypt=False";


            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;


        }


        public static DataTable GetTableByQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DbConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter =
                    new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DbConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }



       //nternal static bool ReferenceEquals(string pri)
        //
       //   throw new NotImplementedException();
       //
    }
}