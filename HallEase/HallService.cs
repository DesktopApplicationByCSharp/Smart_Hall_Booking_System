using HallsProjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HallsProjects
{
    public class HallService
    {
        public bool AddHall(Hall hall)
        {
            string query = @"INSERT INTO Halls (Name, Location, Capacity, Price, Description, ImagePath, OwnerID) 
                             VALUES (@Name, @Location, @Capacity, @Price, @Description, @ImagePath, @OwnerID)";

            SqlParameter[] parameters = {
                new SqlParameter("@Name", hall.Name),
                new SqlParameter("@Location", hall.Location),
                new SqlParameter("@Capacity", hall.Capacity),
                new SqlParameter("@Price", hall.Price),
                new SqlParameter("@Description", hall.Description ?? (object)DBNull.Value),
                new SqlParameter("@ImagePath", hall.ImagePath ?? (object)DBNull.Value),
                new SqlParameter("@OwnerID", hall.OwnerID)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateHall(Hall hall)
        {
            string query = @"UPDATE Halls SET 
                             Name = @Name, 
                             Location = @Location, 
                             Capacity = @Capacity, 
                             Price = @Price, 
                             Description = @Description, 
                             ImagePath = @ImagePath 
                             WHERE HallID = @HallID";

            SqlParameter[] parameters = {
                new SqlParameter("@Name", hall.Name),
                new SqlParameter("@Location", hall.Location),
                new SqlParameter("@Capacity", hall.Capacity),
                new SqlParameter("@Price", hall.Price),
                new SqlParameter("@Description", hall.Description ?? (object)DBNull.Value),
                new SqlParameter("@ImagePath", hall.ImagePath ?? (object)DBNull.Value),
                new SqlParameter("@HallID", hall.HallID)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllHalls()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM Halls");
        }

        public DataTable GetHallsByOwner(int ownerId)
        {
            string query = "SELECT * FROM Halls WHERE OwnerID = @OwnerID";
            SqlParameter[] parameters = { new SqlParameter("@OwnerID", ownerId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable SearchHalls(string location, decimal? minPrice, decimal? maxPrice, int? minCapacity)
        {
            string query = "SELECT * FROM Halls WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(location))
            {
                query += " AND Location LIKE @Location";
                parameters.Add(new SqlParameter("@Location", "%" + location + "%"));
            }

            if (minPrice.HasValue)
            {
                query += " AND Price >= @MinPrice";
                parameters.Add(new SqlParameter("@MinPrice", minPrice.Value));
            }

            if (maxPrice.HasValue)
            {
                query += " AND Price <= @MaxPrice";
                parameters.Add(new SqlParameter("@MaxPrice", maxPrice.Value));
            }

            if (minCapacity.HasValue)
            {
                query += " AND Capacity >= @MinCapacity";
                parameters.Add(new SqlParameter("@MinCapacity", minCapacity.Value));
            }

            return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }

        public Hall GetHallById(int hallId)
        {
            string query = "SELECT * FROM Halls WHERE HallID = @HallID";
            SqlParameter[] parameters = { new SqlParameter("@HallID", hallId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Hall
                {
                    HallID = Convert.ToInt32(row["HallID"]),
                    Name = row["Name"].ToString(),
                    Location = row["Location"].ToString(),
                    Capacity = Convert.ToInt32(row["Capacity"]),
                    Price = Convert.ToDecimal(row["Price"]),
                    Description = row["Description"] == DBNull.Value ? string.Empty : row["Description"].ToString(),
                    ImagePath = row["ImagePath"] == DBNull.Value ? string.Empty : row["ImagePath"].ToString(),
                    OwnerID = Convert.ToInt32(row["OwnerID"])
                };
            }
            return null;
        }

        public (bool IsSuccess, string ErrorMessage) DeleteHall(int hallId)
        {
            string query = "DELETE FROM Halls WHERE HallID = @HallID";
            SqlParameter[] parameters = { new SqlParameter("@HallID", hallId) };
            if (DatabaseHelper.TryExecuteNonQuery(query, parameters, out string errorMessage))
            {
                return (true, null);
            }
            return (false, errorMessage);
        }
    }
}