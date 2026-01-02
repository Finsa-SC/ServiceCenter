using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ServiceCenter.core.network
{
    internal class DBHelper
    {
        private static string connectionString = "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=ServiceCenterDB;Integrated Security=true;TrustServerCertificate=true";

        public static int executeQuery(string query, params SqlParameter[] parameter)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if(parameter != null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public static List<T> executeReader<T>(string query, Func<SqlDataReader, T> func ,params SqlParameter[] parameter)
        {
            List<T> list = new List<T>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameter != null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(func(dr));
                        }
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return list;
        }
    }
}
