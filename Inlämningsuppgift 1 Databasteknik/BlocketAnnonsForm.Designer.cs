namespace Inlämningsuppgift_1_Databasteknik
{
    partial class BlocketAnnonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTitleLoggedin = new System.Windows.Forms.TextBox();
            this.txtDescriptionLoggedin = new System.Windows.Forms.TextBox();
            this.txtPriceLoggedin = new System.Windows.Forms.TextBox();
            this.lblStatusRed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatusGreen = new System.Windows.Forms.Label();
            this.lblActiveAds = new System.Windows.Forms.Label();
            this.lblLoggedInTitle = new System.Windows.Forms.Label();
            this.lblLoggedinDescription = new System.Windows.Forms.Label();
            this.lblLoggedinPrice = new System.Windows.Forms.Label();
            this.comboboxLoggedIn = new System.Windows.Forms.ComboBox();
            this.btnUpdateListing = new System.Windows.Forms.Button();
            this.btnDeleteAd = new System.Windows.Forms.Button();
            this.btnAddNewListing = new System.Windows.Forms.Button();
            this.btnLoadAds = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(235, 110);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fritext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(19, 111);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(167, 20);
            this.txtSearchBox.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(484, 424);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 101);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(966, 76);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(167, 20);
            this.txtUsernameLogin.TabIndex = 7;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(966, 108);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(167, 20);
            this.txtPasswordLogin.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1039, 134);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 23);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Logga in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Användarnamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(909, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lösenord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Har du inget konto? Skapa ett genom att klicka här";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(1074, 28);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(59, 23);
            this.btnCreateAccount.TabIndex = 13;
            this.btnCreateAccount.Text = "Skapa";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(769, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(364, 254);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtTitleLoggedin
            // 
            this.txtTitleLoggedin.Location = new System.Drawing.Point(867, 448);
            this.txtTitleLoggedin.Name = "txtTitleLoggedin";
            this.txtTitleLoggedin.Size = new System.Drawing.Size(266, 20);
            this.txtTitleLoggedin.TabIndex = 15;
            // 
            // txtDescriptionLoggedin
            // 
            this.txtDescriptionLoggedin.Location = new System.Drawing.Point(867, 474);
            this.txtDescriptionLoggedin.Name = "txtDescriptionLoggedin";
            this.txtDescriptionLoggedin.Size = new System.Drawing.Size(266, 20);
            this.txtDescriptionLoggedin.TabIndex = 16;
            // 
            // txtPriceLoggedin
            // 
            this.txtPriceLoggedin.Location = new System.Drawing.Point(867, 505);
            this.txtPriceLoggedin.Name = "txtPriceLoggedin";
            this.txtPriceLoggedin.Size = new System.Drawing.Size(266, 20);
            this.txtPriceLoggedin.TabIndex = 17;
            // 
            // lblStatusRed
            // 
            this.lblStatusRed.AutoSize = true;
            this.lblStatusRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblStatusRed.ForeColor = System.Drawing.Color.Red;
            this.lblStatusRed.Location = new System.Drawing.Point(12, 9);
            this.lblStatusRed.Name = "lblStatusRed";
            this.lblStatusRed.Size = new System.Drawing.Size(82, 17);
            this.lblStatusRed.TabIndex = 19;
            this.lblStatusRed.Text = "EJ Inloggad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // lblStatusGreen
            // 
            this.lblStatusGreen.AutoSize = true;
            this.lblStatusGreen.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatusGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblStatusGreen.ForeColor = System.Drawing.Color.Lime;
            this.lblStatusGreen.Location = new System.Drawing.Point(16, 10);
            this.lblStatusGreen.Name = "lblStatusGreen";
            this.lblStatusGreen.Size = new System.Drawing.Size(62, 17);
            this.lblStatusGreen.TabIndex = 21;
            this.lblStatusGreen.Text = "Inloggad";
            // 
            // lblActiveAds
            // 
            this.lblActiveAds.AutoSize = true;
            this.lblActiveAds.Location = new System.Drawing.Point(775, 159);
            this.lblActiveAds.Name = "lblActiveAds";
            this.lblActiveAds.Size = new System.Drawing.Size(128, 13);
            this.lblActiveAds.TabIndex = 22;
            this.lblActiveAds.Text = "Här är alla dina annonser!";
            // 
            // lblLoggedInTitle
            // 
            this.lblLoggedInTitle.AutoSize = true;
            this.lblLoggedInTitle.Location = new System.Drawing.Point(834, 451);
            this.lblLoggedInTitle.Name = "lblLoggedInTitle";
            this.lblLoggedInTitle.Size = new System.Drawing.Size(27, 13);
            this.lblLoggedInTitle.TabIndex = 23;
            this.lblLoggedInTitle.Text = "Title";
            // 
            // lblLoggedinDescription
            // 
            this.lblLoggedinDescription.AutoSize = true;
            this.lblLoggedinDescription.Location = new System.Drawing.Point(801, 477);
            this.lblLoggedinDescription.Name = "lblLoggedinDescription";
            this.lblLoggedinDescription.Size = new System.Drawing.Size(60, 13);
            this.lblLoggedinDescription.TabIndex = 24;
            this.lblLoggedinDescription.Text = "Description";
            // 
            // lblLoggedinPrice
            // 
            this.lblLoggedinPrice.AutoSize = true;
            this.lblLoggedinPrice.Location = new System.Drawing.Point(830, 505);
            this.lblLoggedinPrice.Name = "lblLoggedinPrice";
            this.lblLoggedinPrice.Size = new System.Drawing.Size(31, 13);
            this.lblLoggedinPrice.TabIndex = 25;
            this.lblLoggedinPrice.Text = "Price";
            // 
            // comboboxLoggedIn
            // 
            this.comboboxLoggedIn.FormattingEnabled = true;
            this.comboboxLoggedIn.Location = new System.Drawing.Point(1012, 531);
            this.comboboxLoggedIn.Name = "comboboxLoggedIn";
            this.comboboxLoggedIn.Size = new System.Drawing.Size(121, 21);
            this.comboboxLoggedIn.TabIndex = 26;
            // 
            // btnUpdateListing
            // 
            this.btnUpdateListing.Location = new System.Drawing.Point(866, 531);
            this.btnUpdateListing.Name = "btnUpdateListing";
            this.btnUpdateListing.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateListing.TabIndex = 27;
            this.btnUpdateListing.Text = "Updatera annons";
            this.btnUpdateListing.UseVisualStyleBackColor = true;
            this.btnUpdateListing.Click += new System.EventHandler(this.btnUpdateListing_Click);
            // 
            // btnDeleteAd
            // 
            this.btnDeleteAd.Location = new System.Drawing.Point(867, 560);
            this.btnDeleteAd.Name = "btnDeleteAd";
            this.btnDeleteAd.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteAd.TabIndex = 28;
            this.btnDeleteAd.Text = "Ta bort annons";
            this.btnDeleteAd.UseVisualStyleBackColor = true;
            this.btnDeleteAd.Click += new System.EventHandler(this.btnDeleteAd_Click);
            // 
            // btnAddNewListing
            // 
            this.btnAddNewListing.Location = new System.Drawing.Point(866, 589);
            this.btnAddNewListing.Name = "btnAddNewListing";
            this.btnAddNewListing.Size = new System.Drawing.Size(267, 23);
            this.btnAddNewListing.TabIndex = 29;
            this.btnAddNewListing.Text = "Lägg till en ny annons";
            this.btnAddNewListing.UseVisualStyleBackColor = true;
            this.btnAddNewListing.Click += new System.EventHandler(this.btnAddNewListing_Click);
            // 
            // btnLoadAds
            // 
            this.btnLoadAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnLoadAds.Location = new System.Drawing.Point(900, 156);
            this.btnLoadAds.Name = "btnLoadAds";
            this.btnLoadAds.Size = new System.Drawing.Size(58, 19);
            this.btnLoadAds.TabIndex = 30;
            this.btnLoadAds.Text = "Ladda";
            this.btnLoadAds.UseVisualStyleBackColor = true;
            this.btnLoadAds.Click += new System.EventHandler(this.btnLoadAds_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(235, 154);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(148, 21);
            this.comboBoxFilter.TabIndex = 31;
           
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 705);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.btnLoadAds);
            this.Controls.Add(this.btnAddNewListing);
            this.Controls.Add(this.btnDeleteAd);
            this.Controls.Add(this.btnUpdateListing);
            this.Controls.Add(this.comboboxLoggedIn);
            this.Controls.Add(this.lblLoggedinPrice);
            this.Controls.Add(this.lblLoggedinDescription);
            this.Controls.Add(this.lblLoggedInTitle);
            this.Controls.Add(this.lblActiveAds);
            this.Controls.Add(this.lblStatusGreen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatusRed);
            this.Controls.Add(this.txtPriceLoggedin);
            this.Controls.Add(this.txtDescriptionLoggedin);
            this.Controls.Add(this.txtTitleLoggedin);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtTitleLoggedin;
        private System.Windows.Forms.TextBox txtDescriptionLoggedin;
        private System.Windows.Forms.TextBox txtPriceLoggedin;
        private System.Windows.Forms.Label lblStatusRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatusGreen;
        private System.Windows.Forms.Label lblActiveAds;
        private System.Windows.Forms.Label lblLoggedInTitle;
        private System.Windows.Forms.Label lblLoggedinDescription;
        private System.Windows.Forms.Label lblLoggedinPrice;
        private System.Windows.Forms.ComboBox comboboxLoggedIn;
        private System.Windows.Forms.Button btnUpdateListing;
        private System.Windows.Forms.Button btnDeleteAd;
        private System.Windows.Forms.Button btnAddNewListing;
        private System.Windows.Forms.Button btnLoadAds;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label6;
    }
}

