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
    public partial class CreateAccountForm : Form
    {
        int userID = GlobalVariables.activeUserID;
        BlocketManager service = GlobalVariables.blocketService;
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsernameCreate.Text) || (string.IsNullOrWhiteSpace(txtPasswordCreate.Text)))
            {
                MessageBox.Show("Vänligen fyll i alla textrutor för att gå vidare");
                return;
            }

            string Username = txtUsernameCreate.Text;
            string Password = txtPasswordCreate.Text;
            
            if(service.AddUser(Username, Password))
            {
                MessageBox.Show("Konto har skapats!\nStäng ner rutan och logga in!");
            }
            else
            {
                MessageBox.Show("Tyvärr, användarnamnet är upptaget\nTesta med något annat!");
            }

        }
    }
}
