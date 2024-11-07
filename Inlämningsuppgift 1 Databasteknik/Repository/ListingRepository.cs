using Inlämningsuppgift_1_Databasteknik.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Inlämningsuppgift_1_Databasteknik.Service;

namespace Inlämningsuppgift_1_Databasteknik.Repository
{
    public class ListingRepository
    {
        private readonly string SQLCS;

        public ListingRepository()
        {
            SQLCS = ConfigurationHelper.GetConnectionString("SQLCS");
        }
        public List<Listing> GetAllListings()
        {
            List<Listing> allListings = new List<Listing>();

            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("GetAllListings", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Listing listing = new Listing();
                    listing.ListingID = (int)reader["ListingID"];
                    listing.Title = reader["Title"].ToString().Trim();
                    listing.Description = reader["Description"].ToString().Trim();
                    listing.Price = (int)reader["Price"];
                    listing.UserID = (int)reader["UserID"];
                    listing.CategoryID = (int)reader["UserID"];
                    listing.DatePosted = (DateTime)reader["DatePosted"];

                    allListings.Add(listing);
                }
                return allListings;
            }
        }

        public bool UpdateListing(int listingId, string title, string description, int price, int categoryID)
        {
            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateListing", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@ListingID", listingId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);

                    conn.Open();

                    // Execute the command and return success status
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if any rows were updated
                }
            }
        }

        public List<Listing> GetAllListingsConnectedToUserID(int userID)
        {
            List<Listing> allListings = new List<Listing>();

            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("GetAllListingsConnectedToUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Listing listing = new Listing();
                    listing.ListingID = (int)reader["ListingID"];
                    listing.Title = reader["Title"].ToString().Trim();
                    listing.Description = reader["Description"].ToString().Trim();
                    listing.Price = (int)reader["Price"];
                    listing.UserID = (int)reader["UserID"]; 
                    listing.CategoryID = (int)reader["CategoryID"];
                    listing.DatePosted = (DateTime)reader["DatePosted"];

                    allListings.Add(listing);
                }
                return allListings;
            }
        }

        public bool AddListing(string title, string description, int price, int categoryID, int userID)
        {
            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("AddListing", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@UserID", userID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public List<Listing> DeleteListing(int listingID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLCS))
                {
                    SqlCommand cmd = new SqlCommand("DeleteListing", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListingID", listingID);
                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery(); // ExecuteNonQuery returns the number of rows affected

                    if (rowsAffected == 0)
                    {
                        // No rows were deleted, which means the categoryID doesn't exist
                        throw new Exception("Category ID not found. Please try again with a valid ID.");
                    }
                }
                // If the deletion was successful, retrieve the updated list of categories
                List<Listing> listings = GetAllListings();
                return listings;
            }
            catch (Exception ex)
            {
                // Log the exception message if needed
                Console.WriteLine("Error: " + ex.Message);

                List<Listing> listings = GetAllListings();
                return listings;
            }


        }
        
        public List<Listing> FilterAndSortListings(string searchText, int categoryID, string sortType, string sortOrder)
        {
            List<Listing> allListings = new List<Listing>();
            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("FilterAndSortListings", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@SearchText", string.IsNullOrEmpty(searchText) ? (object)DBNull.Value : searchText);
                cmd.Parameters.AddWithValue("@SortOrder", sortOrder);
                cmd.Parameters.AddWithValue("@SortField", sortType);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Listing listing = new Listing
                    {
                        ListingID = (int)reader["ListingID"],
                        Title = reader["Title"].ToString().Trim(),
                        Description = reader["Description"].ToString().Trim(),
                        Price = (int)reader["Price"],
                        UserID = (int)reader["UserID"],
                        CategoryID = (int)reader["CategoryID"],
                        DatePosted = (DateTime)reader["DatePosted"]
                    };
                    allListings.Add(listing);
                }
            }
            return allListings;
        }
    }
}
