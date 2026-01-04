using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ServiceCenter.core.util;

namespace ServiceCenter.core.network
{
    internal class DBHelper
    {
        private static string connectionString = "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=ServiceCenterDB;Integrated Security=true;TrustServerCertificate=true";

        public static int executeNonQuery(string query, params SqlParameter[] parameter)
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
                UIHelper.toast("Failed Execution", ex.Message);
                return -1;
            }
        }

        public static DataTable executeQuery(string query, params SqlParameter[] parameter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if(parameter!=null) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }catch(Exception ex)
            {
                UIHelper.toast("Failed Load Data", ex.Message);
                return new DataTable();
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
            }catch(Exception ex) {UIHelper.toast("Failed to Get Data", ex.Message); }
            return list;
        }
    }
}
