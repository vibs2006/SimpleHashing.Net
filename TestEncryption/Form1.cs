using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PV.Hash;
using Data;

namespace TestEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDatabaseSavedStatus.Text = "";
        }
        
        private void clearStatus()
        {
            lblDatabaseSavedStatus.Text = string.Empty;
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            clearStatus();
            if (string.IsNullOrWhiteSpace(txtInputPassword.Text))
            {
                MessageBox.Show("Please Enter Password");
                txtInputPassword.Focus();
            }
            else
            {
                PVHash objPVHash = new PVHash();
                PasswordParameters param = new PasswordParameters();
                param = objPVHash.Compute(txtInputPassword.Text.Trim());

                txtSalt.Text = param.Salt;
                txtHash.Text = param.Hash;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearStatus();
            if (string.IsNullOrWhiteSpace(txtInputPassword.Text))
            {
                MessageBox.Show("Please Enter Password");
                txtInputPassword.Focus();
            }
            else
            {
                PVHash objPVHash = new PVHash();
                bool obj = objPVHash.Verify(txtInputPassword.Text, txtSalt.Text, txtHash.Text);
                setVerificationStatus(obj);
            }
            


        }

        private void setVerificationStatus(bool status)
        {
            if (status)
            {
                lblDatabaseSavedStatus.ForeColor = Color.Green;
                lblDatabaseSavedStatus.Text = "Values Matched";
            }
            else
            {
                lblDatabaseSavedStatus.ForeColor = Color.Red;
                lblDatabaseSavedStatus.Text = "Matched Failed";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveInDatabase_Click(object sender, EventArgs e)
        {
            clearStatus();
            if (verifyBeforeSaveToDB())
            {
                PVData obj = new PVData();

                var results = obj.getUserData(txtInputUsername.Text.Trim());

                if (results.Count() < 1)
                {
                    MessageBox.Show("Sorry user NOT found");
                }
                else
                {
                    //MessageBox.Show("User Found!");

                    obj = null; obj = new PVData();
                    int rowsReturned = obj.UpdateUser(txtSalt.Text.Trim(), txtHash.Text.Trim(), txtInputUsername.Text.Trim());
                    if (rowsReturned > 0)
                    {
                        MessageBox.Show($"User '{txtInputUsername.Text.Trim()}' Updated.");
                    }
                    else
                    {
                        MessageBox.Show("User Updation Failed");
                    }
                }


            }

        }

        private bool verifyBeforeSaveToDB()
        {
            if ( string.IsNullOrWhiteSpace(txtInputUsername.Text.Trim()) || string.IsNullOrWhiteSpace(txtInputPassword.Text.Trim()) 
                || string.IsNullOrWhiteSpace(txtHash.Text.Trim()) || string.IsNullOrWhiteSpace(txtSalt.Text.Trim())
                )
            {
                MessageBox.Show("Please Enter all values");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnVerifyFromDatabase_Click(object sender, EventArgs e)
        {
            clearStatus();
            if (string.IsNullOrWhiteSpace(txtInputUsername.Text))
            {
                MessageBox.Show("Username Must be Entered before searching Username from database!");
            }
            else
            {
                UserData ud = new UserData();
                PVData pv = new PVData();
                var results = pv.getUserData(txtInputUsername.Text.Trim());

                if (results.Count() > 0)
                {
                    foreach (var item in results)
                    {
                        txtSalt.Text = item.PasswordSalt;
                        txtHash.Text = item.NewPassword;
                    }

                    if ( string.IsNullOrEmpty(txtSalt.Text.Trim()) || string.IsNullOrEmpty(txtHash.Text.Trim()))
                    {
                        MessageBox.Show($"It seems that Hash and Salt are not yet saved property for this username. Please Generate Salt and save to Database to create Hash and Salt for {txtInputUsername.Text.Trim()}");
                    }

                }
                else
                {
                    MessageBox.Show("User Details not found!");
                }
            }
        }
    }
}
