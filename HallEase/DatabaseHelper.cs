using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HallsProjects
{
    public static class DatabaseHelper
    {
        // سيتم قراءة هذا من App.config أولاً
        private static string _connectionString =
            "Server=DESKTOP-73TFDUK\\SQLEXPRESS;Database=HallEaseDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

        public static string ConnectionString
        {
            get
            {
                try
                {
                    var csEntry = ConfigurationManager.ConnectionStrings["HallEaseDB"];
                    if (csEntry != null && !string.IsNullOrEmpty(csEntry.ConnectionString))
                        return csEntry.ConnectionString;
                }
                catch { }

                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        private static T ExecuteWithRetry<T>(Func<T> operation)
        {
            try
            {
                return operation();
            }
            catch (SqlException ex) when (ex.Number == 4060)
            {
                // لا يتم إنشاء قواعد بيانات تلقائيًا في SQLEXPRESS
                throw new InvalidOperationException(
                    $"SQL Server لا يستطيع الوصول لقاعدة البيانات '{GetDatabaseName()}'. " +
                    $"تأكد أنها موجودة داخل SQLEXPRESS وأن الاتصال صحيح. SQL Error: {ex.Message}", ex);
            }
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            return ExecuteWithRetry(() =>
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            });
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            return ExecuteWithRetry(() =>
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteNonQuery();
                    }
                }
            });
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            return ExecuteWithRetry(() =>
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteScalar();
                    }
                }
            });
        }

        public static bool TryExecuteNonQuery(string query, SqlParameter[] parameters, out string errorMessage)
        {
            try
            {
                ExecuteNonQuery(query, parameters);
                errorMessage = null;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private static string GetDatabaseName()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(ConnectionString);
                return builder.InitialCatalog;
            }
            catch
            {
                return "(unknown)";
            }
        }
    }
}
