namespace Inlämningsuppgift_1_Databasteknik
{
    partial class AddNewListingForm
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
            this.btnAddListing = new System.Windows.Forms.Button();
            this.cmboxAddCategory = new System.Windows.Forms.ComboBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddListing
            // 
            this.btnAddListing.Location = new System.Drawing.Point(213, 234);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(155, 23);
            this.btnAddListing.TabIndex = 0;
            this.btnAddListing.Text = "Lägg till annons";
            this.btnAddListing.UseVisualStyleBackColor = true;
            this.btnAddListing.Click += new System.EventHandler(this.btnAddListing_Click);
            // 
            // cmboxAddCategory
            // 
            this.cmboxAddCategory.FormattingEnabled = true;
            this.cmboxAddCategory.Location = new System.Drawing.Point(226, 181);
            this.cmboxAddCategory.Name = "cmboxAddCategory";
            this.cmboxAddCategory.Size = new System.Drawing.Size(142, 21);
            this.cmboxAddCategory.TabIndex = 1;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(226, 140);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(142, 20);
            this.txtAddPrice.TabIndex = 2;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(93, 103);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(275, 20);
            this.txtAddDescription.TabIndex = 3;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(93, 56);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(275, 20);
            this.txtAddTitle.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(60, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategori";
            // 
            // AddNewListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtAddTitle);
            this.Controls.Add(this.txtAddDescription);
            this.Controls.Add(this.txtAddPrice);
            this.Controls.Add(this.cmboxAddCategory);
            this.Controls.Add(this.btnAddListing);
            this.Name = "AddNewListingForm";
            this.Text = "AddNewListingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddListing;
        private System.Windows.Forms.ComboBox cmboxAddCategory;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}