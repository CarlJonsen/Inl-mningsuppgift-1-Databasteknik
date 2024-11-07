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
using static Inlämningsuppgift_1_Databasteknik.BlocketAnnonsForm;

namespace Inlämningsuppgift_1_Databasteknik
{
    public partial class AddNewListingForm : Form
    {
        int activeUserID = GlobalVariables.activeUserID;
        BlocketManager service = GlobalVariables.blocketService;
        public AddNewListingForm()
        {
            InitializeComponent();
            List<Category> categoryListLoggedin = service.GetAllCategory();
            cmboxAddCategory.DataSource = categoryListLoggedin;
            cmboxAddCategory.DisplayMember = "CategoryName"; // Name to show in the ComboBox
            cmboxAddCategory.ValueMember = "CategoryID";
        }

        private void btnAddListing_Click(object sender, EventArgs e)
        {
            // Check if the text boxes are not empty
            if (!string.IsNullOrEmpty(txtAddTitle.Text) &&
                !string.IsNullOrEmpty(txtAddDescription.Text) &&
                !string.IsNullOrEmpty(txtAddPrice.Text))
            {
                string Title = txtAddTitle.Text;
                string Description = txtAddDescription.Text;
                int price = int.Parse(txtAddPrice.Text); // Make sure this is a valid integer
                int categoryID = Convert.ToInt32(cmboxAddCategory.SelectedValue); // Ensure the selected category ID is valid

                // Call the service to add the listing

                if(service.AddListing(Title, Description, price, categoryID, activeUserID))
                {
                    MessageBox.Show("Annons skapad!");
                }
                else 
                {
                    // Inform the user that the listing was created
                    MessageBox.Show("Något gick fel. UserID not found");
                }
            }
            else
            {
                // Show a message if any field is empty
                MessageBox.Show("Vänligen fyll i alla textfält!");
            }
        }
    }
}
