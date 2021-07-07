using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPersonelTakip.Model
{
    class IDataBase
    {
        public static string connectionString= @"Data Source=.\SQLEXPRESS;Initial Catalog=KOSDb;Integrated Security=SSPI";

        public static DataTable DataToDataTable(string query, List<SqlParameter> parameters)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters!=null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
                
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }


        public static DataTable DataToDataTable(string query)
        {
            return DataToDataTable(query, new List<SqlParameter>() { });
        }

        public static DataTable DataToDataTable(string query,SqlParameter parameter)
        {
            return DataToDataTable(query, new List<SqlParameter>() { parameter});
        }


        public static void executeNonQuery(string query,List<SqlParameter> parameters)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query,con);
                con.Open();
                if (parameters!=null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                }
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {

                throw ex;
            }
           
        }

        public static void  executeNonQuery(string query, SqlParameter parameter)
        {
             executeNonQuery(query, new List<SqlParameter> { parameter});
        }
        public static object ExecuteScalar(string query,List<SqlParameter> parameters)
        {
            object value = null;


            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                }
                value =cmd.ExecuteScalar();
                con.Close();
                return value;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        
          
        }
    }
}
