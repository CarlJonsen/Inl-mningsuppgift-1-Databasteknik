using Inlämningsuppgift_1_Databasteknik.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Inlämningsuppgift_1_Databasteknik.Service;

namespace Inlämningsuppgift_1_Databasteknik.Repository
{
    public class UserRepository
    {
        private readonly string SQLCS;

        public UserRepository()
        {
            SQLCS = ConfigurationHelper.GetConnectionString("SQLCS");
        }
        public int GetUserIDByUsername(string username)
        {
            int ID = -1; // Default value in case no result is found

            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("SELECT UserID FROM Users WHERE Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                // Check if there's a row and read the value
                if (rdr.Read())
                {
                    ID = (int)rdr["UserID"];
                }

                rdr.Close(); // Close the reader when done
            }

            return ID;
        }

        
        public bool AddUser(string username, string password)
        {
            if (CheckIfUserNameExists(username))
            {
                return false;
            }
            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("AddUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }



        public bool CheckIfUserNameExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("CheckIfUserExist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();

                int userCount = (int)cmd.ExecuteScalar(); // Returns the count of matching records

                return userCount > 0; // If count is greater than 0, the username exists 
            }
        }
        public bool CheckIfUserIDExists(int userID)
        {
            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("CheckIfUserIDExists", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userID);
                conn.Open();

                int userCount = (int)cmd.ExecuteScalar(); // Returns the count of matching records

                return userCount > 0; // If count is greater than 0, the username exists 
            }
        }



        public bool CheckIfPasswordIsCorrect(string username, string password)
        {
            if (CheckIfUserNameExists(username))
            {
                using (SqlConnection conn = new SqlConnection(SQLCS))
                {
                    SqlCommand cmd = new SqlCommand("CheckIfPasswordIsCorrect", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();

                    string storedPassword = cmd.ExecuteScalar() as string;

                    Console.WriteLine("Stored Password: " + storedPassword);
                    Console.WriteLine("Provided Password: " + password);

                    // Ensure storedPassword is not null and matches the provided password
                    return storedPassword != null && storedPassword == password;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
