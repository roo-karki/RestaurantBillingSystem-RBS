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
    public partial class FoodItemForm : Form
    {
        public FoodItemForm()
        {
            InitializeComponent();
            cbCategory.DataSource = cc.getAllCategories();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.SelectedIndex = -1;
            dgvFoodItemDetails.DataSource = fc.getAllFoodItems();

        }
        CategoryClass cc = new CategoryClass();
        FoodItemClass fc = new FoodItemClass();
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = fc.manageFoodItems(0, int.Parse(cbCategory.SelectedValue.ToString()),
                    txtFoodItemName.Text,
                    Double.Parse(txtRate.Text), 1);
                if(rs == true)
                {
                    MessageBox.Show("Food Items successfully Added to Database ");
                    dgvFoodItemDetails.DataSource = fc.getAllFoodItems();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation");
                    HelperClass.makeFieldsBlank(groupBox1);
                }
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void dgvUserDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
