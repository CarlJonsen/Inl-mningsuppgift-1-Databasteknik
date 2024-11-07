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
    public class CategoryRepository
    {
        private readonly string SQLCS;

        public CategoryRepository()
        {
            SQLCS = ConfigurationHelper.GetConnectionString("SQLCS");
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categoriesList = new List<Category>();

            using (SqlConnection conn = new SqlConnection(SQLCS))
            {
                SqlCommand cmd = new SqlCommand("GetAllCategories", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category();
                    category.CategoryID = (int)reader["CategoryID"];
                    category.CategoryName = reader["CategoryName"].ToString().Trim();
                    categoriesList.Add(category);
                }
                return categoriesList;
            }
        }
    }
}
