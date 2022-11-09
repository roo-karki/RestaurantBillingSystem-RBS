using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantDataAccessLayer;
using System.Security.Cryptography;
using System.IO;


namespace RestaurantBillingSystem_RBS
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            dgvUserDetails.DataSource = uc.GetUsers();
               
        }
        UserClass uc = new UserClass();
        int UserId = 0;
       private void btnAdd_Click(object sender, EventArgs e)
        {

            if (invalidValidFields() == false)
            {
                CreateUser();
            }
            else
                return;

        }

        private void CreateUser()
        {
            try
            {
                bool rs = uc.manageUsers(0, txtUserName.Text, Encrypt(txtPassword.Text), cbRole.Text, 1);
                if (rs == true)
                {
                    MessageBox.Show("User Succesfully Created ");
                    dgvUserDetails.DataSource = uc.GetUsers();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in creating users");
                    HelperClass.makeFieldsBlank(groupBox1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                HelperClass.makeFieldsBlank(groupBox1);

            }
        }

        private void dgvUserDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = int.Parse(dgvUserDetails.SelectedRows[0].Cells["UserId"].Value.ToString());
            txtUserName.Text = dgvUserDetails.SelectedRows[0].Cells["UserName"].Value.ToString();
            txtPassword.Text = dgvUserDetails.SelectedRows[0].Cells["Password"].Value.ToString();
            txtConfirmPassword.Text = dgvUserDetails.SelectedRows[0].Cells["Password"].Value.ToString();
            cbRole.Text = dgvUserDetails.SelectedRows[0].Cells["Role"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (invalidValidFields() == false)
            {
                UpdateUser();
            }
            else
                return;
          
        }

        private void UpdateUser()
        {
            try
            {
                bool rs = uc.manageUsers(UserId, txtUserName.Text, txtPassword.Text, cbRole.Text, 2);
                if (rs == true)
                {
                    MessageBox.Show("User Succesfully Updated ");
                    dgvUserDetails.DataSource = uc.GetUsers();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in updating users");
                    HelperClass.makeFieldsBlank(groupBox1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                HelperClass.makeFieldsBlank(groupBox1);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = uc.manageUsers(UserId, txtUserName.Text, txtPassword.Text, cbRole.Text, 3);
                if (rs == true)
                {
                    MessageBox.Show("User Succesfully deleted ");
                    dgvUserDetails.DataSource = uc.GetUsers();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in deleting users");
                    HelperClass.makeFieldsBlank(groupBox1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                HelperClass.makeFieldsBlank(groupBox1);

            }
        }
        public bool invalidValidFields()
        {
            bool rs = false;
            try
            {
               if(txtUserName.Text == "")
                {
                    rs = true;
                    MessageBox.Show("Please provide a Username ");
                 

                }
                else if (txtPassword.Text == "")
                {
                    rs = true;
                    MessageBox.Show("Please provide accurate password");
                    
                }
               else if (txtConfirmPassword.Text == "")
                {
                    rs = true;
                    MessageBox.Show("please confirm your password");
                   
                }
               else if(cbRole.SelectedIndex == -1)
                {
                    rs = true;
                    MessageBox.Show("Please select a role");
                   
                }
               else if(txtPassword.Text != txtConfirmPassword.Text)
                {
                    rs = true;
                    MessageBox.Show("Password do not match");
                    txtConfirmPassword.Clear();
                    txtPassword.Clear();
                    txtPassword.Focus();
                    
                }

            }  
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return rs;
        }
        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "roshan#";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "roshan#";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
