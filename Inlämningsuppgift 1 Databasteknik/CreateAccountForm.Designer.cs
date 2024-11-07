namespace Inlämningsuppgift_1_Databasteknik
{
    partial class CreateAccountForm
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
            this.txtUsernameCreate = new System.Windows.Forms.TextBox();
            this.txtPasswordCreate = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsernameCreate
            // 
            this.txtUsernameCreate.Location = new System.Drawing.Point(160, 72);
            this.txtUsernameCreate.Name = "txtUsernameCreate";
            this.txtUsernameCreate.Size = new System.Drawing.Size(209, 20);
            this.txtUsernameCreate.TabIndex = 0;
            // 
            // txtPasswordCreate
            // 
            this.txtPasswordCreate.Location = new System.Drawing.Point(160, 107);
            this.txtPasswordCreate.Name = "txtPasswordCreate";
            this.txtPasswordCreate.Size = new System.Drawing.Size(209, 20);
            this.txtPasswordCreate.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(294, 133);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Skapa";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Användarnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtPasswordCreate);
            this.Controls.Add(this.txtUsernameCreate);
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernameCreate;
        private System.Windows.Forms.TextBox txtPasswordCreate;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}