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
    public partial class SearchUserBy : Form
    {
        public SearchUserBy()
        {
            InitializeComponent();
            dgvUserList.DataSource = uc.GetUsers();
        }
        UserClass uc = new UserClass();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvUserList.DataSource = uc.GetUserByUserId(int.Parse(txtUserId.Text));
        }
        private void SearchUserBy_Load(object sender, EventArgs e)
        {

        }
    }
}
