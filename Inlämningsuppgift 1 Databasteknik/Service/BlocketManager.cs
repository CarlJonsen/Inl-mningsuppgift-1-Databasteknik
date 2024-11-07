using Inlämningsuppgift_1_Databasteknik.Entities;
using Inlämningsuppgift_1_Databasteknik.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1_Databasteknik.ServiceRepo
{
    public class BlocketManager
    {
        private CategoryRepository categoryRepo;
        private UserRepository userRepo;
        private ListingRepository listingRepo;

        public BlocketManager()
        {
            categoryRepo = new CategoryRepository();
            userRepo = new UserRepository();
            listingRepo = new ListingRepository();
        }



        // Everything to do with the Category here
        public List<Category> GetAllCategory()
        {
            var result = categoryRepo.GetAllCategories();
            return result;
        }



        // Everything to do with the users here

        public int GetUserID(string username)
        {
            var ID = userRepo.GetUserIDByUsername(username);
            return ID;
        }

        public bool AddUser(string Username, string Password)
        {
            var result = userRepo.AddUser(Username, Password);
            return result;
        }

        public bool TryPassword(string username, string password)
        {
            var result = userRepo.CheckIfPasswordIsCorrect(username, password);
            return result;
        }
                        

        // Everything to do with the listings here
        public List<Listing> GetAllListings()
        {
            var result = listingRepo.GetAllListings();
            return result;
        }
        public bool UpdateListing(int listingId, string title, string description, int price, int categoryID)
        {
            var result = listingRepo.UpdateListing(listingId, title, description, price, categoryID);
            return result;
        }

        public List<Listing> GetAllListingConnectedToUser(int userID)
        {
            var result = listingRepo.GetAllListingsConnectedToUserID(userID);
            return result;
        }

        public List<Listing> DeleteListing(int listingID)
        {
            var result = listingRepo.DeleteListing(listingID);
            return result;
        }

        public bool AddListing(string title, string description, int price, int categoryID, int userID)
        {

            if (userRepo.CheckIfUserIDExists(userID))
            {
                listingRepo.AddListing(title, description, price, categoryID, userID);
                return true;
            }
            else 
            {
                return false;
            }
        }

        public List<Listing> FilterAndSortListings(string searchText, int categoryID, string sortType, string sortOrder)
        {
            var result = listingRepo.FilterAndSortListings(searchText, categoryID, sortType, sortOrder);
            return result;
        }

    }
}
