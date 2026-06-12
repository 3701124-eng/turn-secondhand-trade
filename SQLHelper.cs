using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace 转一转校园二手物品交易系统
{
    public class SQLHelper
    {
        private static readonly string connStr =
            ConfigurationManager.ConnectionStrings["SecondHandDB"].ConnectionString;

        public static DataTable Query(string sql, SqlParameter[]? ps = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (ps != null)
                        cmd.Parameters.AddRange(ps);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        public static int Exec(string sql, SqlParameter[]? ps = null)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (ps != null)
                        cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object Scalar(string sql, SqlParameter[]? ps = null)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (ps != null)
                        cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
