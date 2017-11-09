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
            this.txtSalt.Size = new System.Drawing.Size(343, 20);
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
            this.txtHash.Size = new System.Drawing.Size(343, 20);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 372);
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
    }
}

