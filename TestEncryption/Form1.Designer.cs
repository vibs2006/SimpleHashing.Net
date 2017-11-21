namespace TestEncryption
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputPassword = new System.Windows.Forms.TextBox();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblDatabaseSavedStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInputUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveInDatabase = new System.Windows.Forms.Button();
            this.btnVerifyFromDatabase = new System.Windows.Forms.Button();
            this.btnUpdateAllUsersWithNewPassword = new System.Windows.Forms.Button();
            this.btnVerifyAllUsers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserNameToVerify = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordToVerify = new System.Windows.Forms.TextBox();
            this.lblIndividualUserHashVerificationStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnCheckIndividualUsernameNewPassword = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblBatchStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password";
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(146, 61);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.Size = new System.Drawing.Size(192, 20);
            this.txtInputPassword.TabIndex = 1;
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(146, 116);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.ReadOnly = true;
            this.txtSalt.Size = new System.Drawing.Size(285, 20);
            this.txtSalt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generated Salt is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Generated Hash Is";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(146, 142);
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(285, 20);
            this.txtHash.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(146, 179);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(285, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Geneate New Hash and Salt";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(146, 208);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(285, 23);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "Verify Entered Password = Salt and Hash Combination";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblDatabaseSavedStatus
            // 
            this.lblDatabaseSavedStatus.AutoSize = true;
            this.lblDatabaseSavedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseSavedStatus.Location = new System.Drawing.Point(148, 90);
            this.lblDatabaseSavedStatus.Name = "lblDatabaseSavedStatus";
            this.lblDatabaseSavedStatus.Size = new System.Drawing.Size(54, 17);
            this.lblDatabaseSavedStatus.TabIndex = 9;
            this.lblDatabaseSavedStatus.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Username";
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(146, 25);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(192, 20);
            this.txtInputUsername.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "(ParcelHero_Test)";
            // 
            // btnSaveInDatabase
            // 
            this.btnSaveInDatabase.Location = new System.Drawing.Point(146, 237);
            this.btnSaveInDatabase.Name = "btnSaveInDatabase";
            this.btnSaveInDatabase.Size = new System.Drawing.Size(285, 23);
            this.btnSaveInDatabase.TabIndex = 13;
            this.btnSaveInDatabase.Text = "Save Hash and Salt To Username in Database";
            this.btnSaveInDatabase.UseVisualStyleBackColor = true;
            this.btnSaveInDatabase.Click += new System.EventHandler(this.btnSaveInDatabase_Click);
            // 
            // btnVerifyFromDatabase
            // 
            this.btnVerifyFromDatabase.Location = new System.Drawing.Point(146, 266);
            this.btnVerifyFromDatabase.Name = "btnVerifyFromDatabase";
            this.btnVerifyFromDatabase.Size = new System.Drawing.Size(285, 23);
            this.btnVerifyFromDatabase.TabIndex = 15;
            this.btnVerifyFromDatabase.Text = "Get Hash and Salt from Database for User";
            this.btnVerifyFromDatabase.UseVisualStyleBackColor = true;
            this.btnVerifyFromDatabase.Click += new System.EventHandler(this.btnVerifyFromDatabase_Click);
            // 
            // btnUpdateAllUsersWithNewPassword
            // 
            this.btnUpdateAllUsersWithNewPassword.Location = new System.Drawing.Point(479, 61);
            this.btnUpdateAllUsersWithNewPassword.Name = "btnUpdateAllUsersWithNewPassword";
            this.btnUpdateAllUsersWithNewPassword.Size = new System.Drawing.Size(337, 23);
            this.btnUpdateAllUsersWithNewPassword.TabIndex = 18;
            this.btnUpdateAllUsersWithNewPassword.Text = "Update All Users with New Hash Password";
            this.btnUpdateAllUsersWithNewPassword.UseVisualStyleBackColor = true;
            this.btnUpdateAllUsersWithNewPassword.Click += new System.EventHandler(this.btnUpdateAllUsersWithNewPassword_Click);
            // 
            // btnVerifyAllUsers
            // 
            this.btnVerifyAllUsers.Location = new System.Drawing.Point(479, 90);
            this.btnVerifyAllUsers.Name = "btnVerifyAllUsers";
            this.btnVerifyAllUsers.Size = new System.Drawing.Size(337, 23);
            this.btnVerifyAllUsers.TabIndex = 20;
            this.btnVerifyAllUsers.Text = "Verify All Users with New Password";
            this.btnVerifyAllUsers.UseVisualStyleBackColor = true;
            this.btnVerifyAllUsers.Click += new System.EventHandler(this.btnVerifyAllUsers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Enter UserName";
            // 
            // txtUserNameToVerify
            // 
            this.txtUserNameToVerify.Location = new System.Drawing.Point(587, 181);
            this.txtUserNameToVerify.Name = "txtUserNameToVerify";
            this.txtUserNameToVerify.Size = new System.Drawing.Size(177, 20);
            this.txtUserNameToVerify.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Enter Password";
            // 
            // txtPasswordToVerify
            // 
            this.txtPasswordToVerify.Location = new System.Drawing.Point(587, 210);
            this.txtPasswordToVerify.Name = "txtPasswordToVerify";
            this.txtPasswordToVerify.Size = new System.Drawing.Size(177, 20);
            this.txtPasswordToVerify.TabIndex = 24;
            // 
            // lblIndividualUserHashVerificationStatus
            // 
            this.lblIndividualUserHashVerificationStatus.AutoSize = true;
            this.lblIndividualUserHashVerificationStatus.Location = new System.Drawing.Point(584, 239);
            this.lblIndividualUserHashVerificationStatus.Name = "lblIndividualUserHashVerificationStatus";
            this.lblIndividualUserHashVerificationStatus.Size = new System.Drawing.Size(0, 13);
            this.lblIndividualUserHashVerificationStatus.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(587, 32);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Size = new System.Drawing.Size(146, 20);
            this.txtTableName.TabIndex = 16;
            this.txtTableName.Text = "M_WebUsersForHash";
            // 
            // btnCheckIndividualUsernameNewPassword
            // 
            this.btnCheckIndividualUsernameNewPassword.Location = new System.Drawing.Point(587, 258);
            this.btnCheckIndividualUsernameNewPassword.Name = "btnCheckIndividualUsernameNewPassword";
            this.btnCheckIndividualUsernameNewPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIndividualUsernameNewPassword.TabIndex = 26;
            this.btnCheckIndividualUsernameNewPassword.Text = "Verify";
            this.btnCheckIndividualUsernameNewPassword.UseVisualStyleBackColor = true;
            this.btnCheckIndividualUsernameNewPassword.Click += new System.EventHandler(this.btnCheckIndividualUsernameNewPassword_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(12, 440);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(35, 13);
            this.lblConnectionString.TabIndex = 27;
            this.lblConnectionString.Text = "label9";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(479, 116);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 28;
            this.progressBar1.Value = 1;
            // 
            // lblBatchStatus
            // 
            this.lblBatchStatus.AutoSize = true;
            this.lblBatchStatus.Location = new System.Drawing.Point(476, 145);
            this.lblBatchStatus.Name = "lblBatchStatus";
            this.lblBatchStatus.Size = new System.Drawing.Size(0, 13);
            this.lblBatchStatus.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 462);
            this.Controls.Add(this.lblBatchStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.btnCheckIndividualUsernameNewPassword);
            this.Controls.Add(this.lblIndividualUserHashVerificationStatus);
            this.Controls.Add(this.txtPasswordToVerify);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUserNameToVerify);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVerifyAllUsers);
            this.Controls.Add(this.btnUpdateAllUsersWithNewPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnVerifyFromDatabase);
            this.Controls.Add(this.btnSaveInDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInputUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDatabaseSavedStatus);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.txtInputPassword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputPassword;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblDatabaseSavedStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveInDatabase;
        private System.Windows.Forms.Button btnVerifyFromDatabase;
        private System.Windows.Forms.Button btnUpdateAllUsersWithNewPassword;
        private System.Windows.Forms.Button btnVerifyAllUsers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserNameToVerify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswordToVerify;
        private System.Windows.Forms.Label lblIndividualUserHashVerificationStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnCheckIndividualUsernameNewPassword;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblBatchStatus;
    }
}

