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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            dgvCategoryDetails.DataSource = cc.getAllCategories();
        }
        CategoryClass cc = new CategoryClass();
        int CategoryId = 0;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = cc.manageCategory(0, txtCategoryName.Text, txtDescription.Text, 1);
                if(rs == true)
                {
                    MessageBox.Show("Category Succesfully Created");
                    dgvCategoryDetails.DataSource = cc.getAllCategories();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation ");
                    HelperClass.makeFieldsBlank(groupBox1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
          
            }

        }

        private void dgvCategoryDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryId = int.Parse(dgvCategoryDetails.SelectedRows[0].Cells["CategoryId"].Value.ToString());
            txtCategoryName.Text = dgvCategoryDetails.SelectedRows[0].Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dgvCategoryDetails.SelectedRows[0].Cells["Description"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = cc.manageCategory(CategoryId, txtCategoryName.Text, txtDescription.Text, 2);
                if (rs == true)
                {
                    MessageBox.Show("Category Succesfully Updated");
                    dgvCategoryDetails.DataSource = cc.getAllCategories();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in updating the required operation ");
                    HelperClass.makeFieldsBlank(groupBox1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = cc.manageCategory(CategoryId, txtCategoryName.Text, txtDescription.Text, 3);
                if (rs == true)
                {
                    MessageBox.Show("Category Succesfully Deleted");
                    dgvCategoryDetails.DataSource = cc.getAllCategories();
                    HelperClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("Error in deleting the required operation ");
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
