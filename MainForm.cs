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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString();
            dgvKOTDetails.DataSource = kc.getAllKOTs();
            cbCategory.DataSource = cc.getAllCategories();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.SelectedIndex = -1;
        }
        KOTClass kc = new KOTClass();
        CategoryClass cc = new CategoryClass();
        FoodItemClass fic = new FoodItemClass();
        OrderClass oc = new OrderClass();
        BillingClass bc = new BillingClass();
      
        

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.ShowDialog();
        }

        private void mangeFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodItemForm fi = new FoodItemForm();
            fi.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfoForm ci = new CompanyInfoForm();
            ci.ShowDialog();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateKOT_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = kc.manageKOT(0,
                    DateTime.Parse(dtpDate.Text), txtKOTBy.Text, 1);
                   if(rs == true)
                {
                    MessageBox.Show("KOT Successfully Generated");
                    dgvKOTDetails.DataSource = kc.getAllKOTs();
                }
                   else
                {
                    MessageBox.Show("Error in performing the required operation");
                }
                    

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgvKOTDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblKOT.Text = dgvKOTDetails.SelectedRows[0].Cells["KOTId"].Value.ToString();
            dtpDate.Text = dgvKOTDetails.SelectedRows[0].Cells["KOTDate"].Value.ToString();
            txtKOTBy.Text = dgvKOTDetails.SelectedRows[0].Cells["KOTBy"].Value.ToString();
            dgvOrderDetails.DataSource = oc.getAllOrders(int.Parse(lblKOT.Text));
            getTotalBillAmount();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbFoodItemName.DataSource = fic.getAllFoodItemsByCategoryId(int.Parse(cbCategory.SelectedValue.ToString()));
                cbFoodItemName.DisplayMember = "FoodItemName";
                cbFoodItemName.ValueMember = "FoodItemId";
                cbFoodItemName.SelectedIndex = -1;



            }
            catch (Exception)
            {

                
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void daywiseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datewiseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void foodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void foodIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void foodItemNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bIllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bIllIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKOTDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteKOT_Click(object sender, EventArgs e)
        {

        }

        private void btnEditKOT_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKOTBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblKOT_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerateBills_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItems_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {

        }

        private void btnFoodItems_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFoodItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnFoodItems_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(lblKOT.Text == "0")
                {
                    MessageBox.Show("Please choose KOT");
                }
                else
                {
                    bool rs = oc.manageOrders(0,
                        int.Parse(lblKOT.Text),
                        int.Parse(cbFoodItemName.SelectedValue.ToString()),
                        Double.Parse(txtQuantity.Text), 1
                        );
                  if(rs == true)
                    {
                        MessageBox.Show("Order Taken Successfully");
                        dgvOrderDetails.DataSource = oc.getAllOrders(int.Parse(lblKOT.Text));
                        getTotalBillAmount();
                    }
                    else
                    {
                        MessageBox.Show("Error in performing the required operation ");
                    }

                }

            }
            catch (Exception ex )
            {

                throw ex;
            }

        }
        public void getTotalBillAmount()
        {
            Double totalAmount = 0;
            for(int i = 0;i< dgvOrderDetails.Rows.Count;i++)
            {
                totalAmount += double.Parse(dgvOrderDetails.Rows[i].Cells["Amount"].Value.ToString()); 

            }
            lblTotalAmount.Text = totalAmount.ToString();

        }

        private void btnGenerateBills_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool rs = bc.manageBill(0, int.Parse(lblKOT.Text),
                    Double.Parse(lblTotalAmount.Text), 1);
               
                if (rs == true)
                {
                    MessageBox.Show("Bill Successfully Saved");
                    
                    DialogResult dr = MessageBox.Show("Do you want to print the bill? ", "Print the Bill"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        BillingForm frm = new BillingForm();
                        frm.KOTId = int.Parse(lblKOT.Text);
                        frm.ShowDialog();
                    }
                    else { return; }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void userIdToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search.SearchUserBy frm = new Search.SearchUserBy();
            frm.ShowDialog();
        }

        private void userNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search.SearchUserByUserName frm = new Search.SearchUserByUserName();
            frm.ShowDialog();
        }
    }
}
