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

namespace RestaurantBillingSystem_RBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserClass uc = new UserClass();
         private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Role = uc.RoleBasedLogin(txtUsername.Text, txtPassword.Text);
                if (Role == "Admin")
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else if (Role == "User")
                {
                    MainForm frm = new MainForm();
                    frm.adminMenu.Enabled = false;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserName and Password");
                    HelperClass.makeFieldsBlank(groupBox1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
