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
        public static readonly string connectionString = "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=ServiceCenterDB;Integrated Security=true;TrustServerCertificate=true";


        private static T Execute<T>(
            string query,
            Func<SqlCommand, T> func,
            params SqlParameter[] parameter
        )
        {
            try
            {
                using(var conn = new SqlConnection( connectionString ))
                using(var cmd = new SqlCommand(query, conn))
                {
                    if (parameter.Length > 0) cmd.Parameters.AddRange(parameter);
                    conn.Open();
                    return func(cmd);
                }
            }catch (Exception ex)
            {
                throw new DataException("Error Database: ", ex);
            }
        }

        public static object executeScalar(string query, params SqlParameter[] parameter)
        {
            return Execute(query, cmd => cmd.ExecuteScalar(), parameter);
        }
        public static int executeNonQuery(string query, params SqlParameter[] parameter)
        {
            return Execute(query, cmd => cmd.ExecuteNonQuery(), parameter);
        }

        public static DataTable executeQuery(string query, params SqlParameter[] parameter)
        {
            return Execute(query, cmd =>
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            },
            parameter
            );
        }
        public static List<T> executeReader<T>(string query, Func<SqlDataReader, T> func ,params SqlParameter[] parameter)
        {
            return Execute(query, cmd =>
            {
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                List<T> list = new List<T>();
                    while (dr.Read())
                    {
                        list.Add(func(dr));
                    }
                return list;
                }

            }, parameter
            );
        }
    }
}
