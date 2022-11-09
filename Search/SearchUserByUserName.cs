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

namespace RestaurantBillingSystem_RBS.Search
{
    public partial class SearchUserByUserName : Form
    {
        UserClass uc = new UserClass();
        public SearchUserByUserName()
        {
            InitializeComponent();
            dgvUserList.DataSource = uc.GetUsers();
             
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUserList.DataSource = uc.GetUserByUserName(txtUserName.Text);
            }
            catch (Exception)
            {

               
            }
        }
    }
}
