using System;
using System.Data;
using System.Data.SqlClient;

namespace HallsProjects
{
    public class AuthService
    {
        public User Login(string email, string password)
        {
            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new User
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    Name = row["Name"].ToString(),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
            }

            return null;
        }

        public bool Register(string name, string email, string password, string role)
        {
            // Check if email already exists
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            SqlParameter[] checkParams = { new SqlParameter("@Email", email) };
            object result = DatabaseHelper.ExecuteScalar(checkQuery, checkParams);
            int count = Convert.ToInt32(result ?? 0);

            if (count > 0)
            {
                return false; // Email already exists
            }

            string query = "INSERT INTO Users (Name, Email, Password, Role) VALUES (@Name, @Email, @Password, @Role)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@Role", role)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllUsers()
        {
            return DatabaseHelper.ExecuteQuery("SELECT UserID, Name, Email, Password, Role FROM Users");
        }

        public (bool IsSuccess, string ErrorMessage) DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };

            if (DatabaseHelper.TryExecuteNonQuery(query, parameters, out string errorMessage))
            {
                return (true, null);
            }
            return (false, errorMessage);
        }

        public bool UpdateUser(int userId, string name, string email, string password, string role)
        {
            string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password, Role = @Role WHERE UserID = @UserID";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@Role", role),
                new SqlParameter("@UserID", userId)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}