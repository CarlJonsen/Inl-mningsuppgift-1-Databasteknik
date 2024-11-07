using Inlämningsuppgift_1_Databasteknik.Entities;
using Inlämningsuppgift_1_Databasteknik.ServiceRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inlämningsuppgift_1_Databasteknik
{
    public partial class BlocketAnnonsForm : Form
    {
        public static class GlobalVariables
        {
            // Public static variables
            public static BlocketManager blocketService = new BlocketManager();
            public static int activeUserID = -1;
        }
        int activeUserID;
        BlocketManager blocketService = GlobalVariables.blocketService;
        public BlocketAnnonsForm()
        {
            InitializeComponent();
            ShowFrontendStart();           
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text;
            int selectedCategoryID = Convert.ToInt32(comboBoxCategory.SelectedValue);
            
            string sortOrder = "";
            string sortType = "";

            switch (comboBoxFilter.SelectedItem.ToString())
            {
                case "Price (Low to High)":
                    sortOrder = "ASC";
                    sortType = "Price";
                    break;
                case "Price (High to Low)":
                    sortOrder = "DESC";
                    sortType = "Price";
                    break;
                case "Date (Newest to Oldest)":
                    sortOrder = "DESC";
                    sortType = "Date";
                    break;
                case "Date (Oldest to Newest)":
                    sortOrder = "ASC";
                    sortType = "Date";
                    break;
            }

            dataGridView1.DataSource = blocketService.FilterAndSortListings(searchText, selectedCategoryID, sortType, sortOrder);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Makes sure the click isnt "Header Row"
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get the values from the row for Title, Description, and Price
                string title = row.Cells["Title"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();

                richTextBox1.Text = $"Title: {title}\n\nDescription:\n{description}\n\nPris: {price}.kr";
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;
            if (blocketService.TryPassword(username, password))
            {   
                MessageBox.Show("Du är inloggad!");
                activeUserID = blocketService.GetUserID(username);
                GlobalVariables.activeUserID = activeUserID;
                ShowLogInFrontend();
                lblStatusGreen.Visible = true;
                lblStatusRed.Visible = false;
                clearTXTboxes();
            }
            else 
            {
                MessageBox.Show("Incorrect credentials, please try again.\nRemember to check CapsLock!");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            CreateAccountForm createAccountForm = new CreateAccountForm();
          
            createAccountForm.ShowDialog();
        } // This Clickevent opens a new Form
       
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.CurrentRow != null)
            {
                txtTitleLoggedin.Text = dataGridView2.CurrentRow.Cells["Title"].Value.ToString();
                txtDescriptionLoggedin.Text = dataGridView2.CurrentRow.Cells["Description"].Value.ToString();
                txtPriceLoggedin.Text = dataGridView2.CurrentRow.Cells["Price"].Value.ToString();
                // Get the CategoryID from the selected row
                int categoryID = (int)dataGridView2.CurrentRow.Cells["CategoryID"].Value;

                // Set ComboBox to the appropriate CategoryID (this will update the Category name in the ComboBox)
                comboboxLoggedIn.SelectedValue = categoryID;
            }
        }

        private void btnUpdateListing_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView (ListingID exists)
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please select a listing to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(txtTitleLoggedin.Text) ||
                string.IsNullOrWhiteSpace(txtDescriptionLoggedin.Text) ||
                string.IsNullOrWhiteSpace(txtPriceLoggedin.Text) ||
                comboboxLoggedIn.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields before updating the listing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try to parse price as integer
            int price;
            if (!int.TryParse(txtPriceLoggedin.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            int listingID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ListingID"].Value);
            string title = txtTitleLoggedin.Text;
            string description = txtDescriptionLoggedin.Text;
            int categoryID = Convert.ToInt32(comboboxLoggedIn.SelectedValue);

            blocketService.UpdateListing(listingID, title, description, price, categoryID);
            ShowLogInFrontend();
            clearTXTboxes();
        }

        private void btnDeleteAd_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please select a listing to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int listingID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ListingID"].Value);
            blocketService.DeleteListing(listingID);
            MessageBox.Show("Din annons är borttagen");
            ShowLogInFrontend();
            clearTXTboxes();
        }
        private void btnAddNewListing_Click(object sender, EventArgs e)
        {
            AddNewListingForm addNewListingForm = new AddNewListingForm();

            // Show the new form as a modal dialog (blocks interaction with the main form until closed)
            addNewListingForm.ShowDialog();
        }// This Clickevent opens a new Form

        private void ShowLogInFrontend()
        {
            dataGridView2.Visible = true;
            txtDescriptionLoggedin.Visible = true;
            txtPriceLoggedin.Visible = true;
            txtTitleLoggedin.Visible = true;
            lblActiveAds.Visible = true;
            btnAddNewListing.Visible = true;
            btnDeleteAd.Visible = true;
            btnUpdateListing.Visible = true;
            comboboxLoggedIn.Visible = true;
            lblLoggedinDescription.Visible = true;
            lblLoggedinPrice.Visible = true;
            lblLoggedInTitle.Visible = true;
            btnLoadAds.Visible = true;
            dataGridView2.DataSource = blocketService.GetAllListingConnectedToUser(activeUserID);
            dataGridView2.Columns["ListingID"].Visible = false;
            dataGridView2.Columns["CategoryID"].Visible = false;
            dataGridView2.Columns["UserID"].Visible = false;

        }

        public void ShowFrontendStart()
        {
            dataGridView1.DataSource = blocketService.GetAllListings();
            dataGridView1.Columns["ListingID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
            LoadDropDownBoxes();
            lblStatusGreen.Visible = false;
            dataGridView2.Visible = false;
            txtDescriptionLoggedin.Visible = false;
            txtPriceLoggedin.Visible = false;
            txtTitleLoggedin.Visible = false;
            lblActiveAds.Visible = false;
            lblLoggedinDescription.Visible = false;
            lblLoggedinPrice.Visible = false;
            lblLoggedInTitle.Visible = false;
            btnAddNewListing.Visible = false;
            btnDeleteAd.Visible = false;
            btnUpdateListing.Visible = false;
            comboboxLoggedIn.Visible = false;
            btnLoadAds.Visible = false ;
            
        }

        public void clearTXTboxes()
        {
            txtDescriptionLoggedin.Clear();
            txtPriceLoggedin.Clear();
            txtTitleLoggedin.Clear();
            txtPasswordLogin.Clear();
            txtUsernameLogin.Clear();
        }

        public void LoadDropDownBoxes()
        {
            List<Category> categoryList = blocketService.GetAllCategory();
            // Insert a new item at the start of the list, representing "Everything" (Allt)
            // The CategoryID is set to 0 to represent "no category filter"
            categoryList.Insert(0, new Category { CategoryID = 0, CategoryName = "<No Filter>" });
            comboBoxCategory.DataSource = categoryList;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";


            List<Category> categoryListLoggedin = blocketService.GetAllCategory();
            comboboxLoggedIn.DataSource = categoryListLoggedin;
            comboboxLoggedIn.DisplayMember = "CategoryName"; // Name to show in the ComboBox
            comboboxLoggedIn.ValueMember = "CategoryID";

            comboBoxFilter.Items.Add("Price (Low to High)");
            comboBoxFilter.Items.Add("Price (High to Low)");
            comboBoxFilter.Items.Add("Date (Newest to Oldest)");
            comboBoxFilter.Items.Add("Date (Oldest to Newest)");
            comboBoxFilter.Items.Insert(0, "<NoFilter>");
            comboBoxFilter.SelectedIndex = 0;
        }

        private void btnLoadAds_Click(object sender, EventArgs e)
        {
            ShowLogInFrontend();
            clearTXTboxes();
        }

     
      
    }
}
