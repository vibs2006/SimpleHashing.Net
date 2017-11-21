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
using System.IO;
using System.Web.Script.Serialization;

namespace TestEncryption
{
    public partial class Form1 : Form
    {
        string _connectionString;
        string _tableName;

        public Form1()
        {
            InitializeComponent();
            lblDatabaseSavedStatus.Text = "";
            FileDTO fd = getDTOObjectFromString(readTextFileAsString("data.txt"));
            _connectionString = fd.connectionString;
            _tableName = fd.tableName;
            txtTableName.Text = _tableName;
            lblConnectionString.Text = _connectionString;
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
                string passwordHashString = objPVHash.Compute(txtInputPassword.Text.Trim());
                txtSalt.Text = passwordHashString.Split('$')[0];
                txtHash.Text = passwordHashString.Split('$')[1];
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
                bool obj = objPVHash.Verify(txtInputPassword.Text, txtSalt.Text+ "$" +txtHash.Text);
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

                var results = obj.getUserData(txtInputUsername.Text.Trim(),_connectionString,_tableName);

                if (results.Count() < 1)
                {
                    MessageBox.Show("Sorry user NOT found");
                }
                else
                {
                    //MessageBox.Show("User Found!");

                    obj = null; obj = new PVData();
                    int rowsReturned = obj.UpdateUser(txtSalt.Text.Trim() + "$" + txtHash.Text.Trim(), txtInputUsername.Text.Trim(),_connectionString,_tableName);
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
                var results = pv.getUserData(txtInputUsername.Text.Trim(),_connectionString,_tableName);

                if (results.Count() > 0)
                {
                    foreach (var item in results)
                    {                     
                        txtSalt.Text = item.NewPassword.Split('$')[0];
                        txtHash.Text = item.NewPassword.Split('$')[1];
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

        private void btnUpdateAllUsersWithNewPassword_Click(object sender, EventArgs e)
        {
            lblBatchStatus.Text = string.Empty;

            btnUpdateAllUsersWithNewPassword.Enabled = false;
            var results = new PVData().getAllUsers(_connectionString,_tableName);
            IPVHash objPVHash = new PVHash();
            int totalCount = results.Count();
            progressBar1.Maximum = totalCount;
            progressBar1.Minimum = 1;
            int currentCount = 0;
            if (results.Count() > 1)
            {
                foreach (var item in results)
                {
                    var objPVData = new PVData();
                    objPVData.UpdateUser(objPVHash.Compute(item.PlainTextPassword.Trim()), item.User_Name, _connectionString, _tableName);
                    currentCount = currentCount + 1;                    
                    progressBar1.Value = currentCount;
                }


                lblBatchStatus.Text = $"All {totalCount} Users Successfully Processed";
            }
            else
            {
                MessageBox.Show("There is no user data in database");
            }
            btnUpdateAllUsersWithNewPassword.Enabled = true;
        }

        /// <summary>
        /// All data should be in one line
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string readTextFileAsString(string fileName)
        {
            using (StreamReader objStreamReader = new StreamReader(fileName))
            {
                return objStreamReader.ReadLine();
            }
        }

        private FileDTO getDTOObjectFromString(string s)
        {
            JavaScriptSerializer _serializer = new JavaScriptSerializer();
            return _serializer.Deserialize<FileDTO>(s);            
        }

        private string saveStringFromDTOObject(FileDTO fd)
        {
            JavaScriptSerializer _serializer = new JavaScriptSerializer();
            return _serializer.Serialize(fd);
        }

        private void btnCheckIndividualUsernameNewPassword_Click(object sender, EventArgs e)
        {
            PVData objPVData = new PVData();

            if (string.IsNullOrEmpty(txtUserNameToVerify.Text.Trim()) || string.IsNullOrEmpty(txtPasswordToVerify.Text.Trim()))
            {
                MessageBox.Show("Username and Password must be NOT empty!");
            }
            else
            {
                var result = objPVData.getUserData(txtUserNameToVerify.Text.Trim(), _connectionString, _tableName);
                var objUserData = result.First();

                if (result.Count() > 0 )
                {                    
                    IPVHash objPVHash = new PVHash();
                    if (objPVHash.Verify(txtPasswordToVerify.Text.Trim(),objUserData.NewPassword))
                    {
                        lblIndividualUserHashVerificationStatus.ForeColor = Color.Green;                        
                        lblIndividualUserHashVerificationStatus.Text = "Username and password are CORRECT!";
                    }
                    else
                    {
                        lblIndividualUserHashVerificationStatus.ForeColor = Color.Red;
                        lblIndividualUserHashVerificationStatus.Text = "Username and password doesn't Match!";
                    }
                }
                else
                {
                    MessageBox.Show($"Username '{txtUserNameToVerify.Text}' NOT Found!");
                }


            }
        }

        private void btnVerifyAllUsers_Click(object sender, EventArgs e)
        {
            lblBatchStatus.Text = string.Empty;
            PVData objPVData = new PVData();
            IPVHash objPVHash = new PVHash();
            var results = objPVData.getAllUsers(_connectionString, _tableName);
            int countValidVerifications=0;
            int countInvalidVerifications=0;
            int loopCounter = 0;

            if (results.Count() > 0 )
            {
                progressBar1.Minimum = 1;
                progressBar1.Maximum = results.Count();
                
                foreach (var item in results)
                {
                    PVData objInnerPVData = new PVData();

                    bool RowResult = objPVHash.Verify(item.PlainTextPassword, item.NewPassword);

                    if (RowResult)
                    {
                        countValidVerifications = countValidVerifications + 1;
                    }
                    else
                    {
                        countInvalidVerifications = countInvalidVerifications + 1;
                    }

                    loopCounter = loopCounter + 1;
                    progressBar1.Value = loopCounter;
                }

                lblBatchStatus.Text = $"Total Number of Successful Verifications are {countValidVerifications.ToString()} and Total Number of Failed Verifications are {countInvalidVerifications.ToString()}.";

            }
            else
            {
                MessageBox.Show("No Users Found!");
            }

        }
    }

    [Serializable]
    public class FileDTO
    {
        public string connectionString { get; set; }
        public string tableName { get; set; }
    }


}
