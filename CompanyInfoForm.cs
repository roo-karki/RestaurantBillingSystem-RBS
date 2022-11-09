using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using RestaurantDataAccessLayer;
using System.IO;


namespace RestaurantBillingSystem_RBS
{
    public partial class CompanyInfoForm : Form
    {
        public CompanyInfoForm()
        {
            InitializeComponent();
            CompanyInfo();
        }

        private void CompanyInfo()
        {
            if (cc.getCompanyInfo().Rows.Count > 0)
            {
                btnAddCompanyInfo.Enabled = false;
                DataTable dt = new DataTable();
                dt = cc.getCompanyInfo();
                txtCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtContact.Text = dt.Rows[0]["Contact"].ToString();
                txtVatPanNo.Text = dt.Rows[0]["Vat_PanNumber"].ToString();
                txtRegistrationNumber.Text = dt.Rows[0]["RegistrationNumber"].ToString();
                byte[] CompanyLogo = (byte[])dt.Rows[0]["CompanyLogo"];
                MemoryStream mem = new MemoryStream(CompanyLogo, 0, CompanyLogo.Length);
                //but an error takes place on next line "Parameter is not valid."
                pbLogo.Image = Image.FromStream(mem);

                CompanyId = int.Parse(dt.Rows[0]["CompanyId"].ToString());
            }
        }

        CompanyClass cc = new CompanyClass();
        public int CompanyId = 0;

       private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK  )
            {
                pbLogo.Image = Image.FromFile(ofd.FileName);

            
            }

        }

        private void btnAddCompanyInfo_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                byte[] CompanyLogo = null;
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                CompanyLogo = ms.ToArray();
                bool rs = cc.manageCompanyInfo(0,
                    txtCompanyName.Text,
                    txtAddress.Text,
                    txtContact.Text, txtVatPanNo.Text, txtRegistrationNumber.Text,
                    CompanyLogo, 1);

                    
                if(rs == true)
                {
                    MessageBox.Show("Company Information Successfully stored ");
                    HelperClass.makeFieldsBlank(groupBox1);
                   
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

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                byte[] CompanyLogo = null;
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                CompanyLogo = ms.ToArray();
                bool rs = cc.manageCompanyInfo(CompanyId,
                    txtCompanyName.Text,
                    txtAddress.Text,
                    txtContact.Text, txtVatPanNo.Text, txtRegistrationNumber.Text,
                    CompanyLogo, 2);


                if (rs == true)
                {
                    MessageBox.Show("Company Information Successfully Updated ");
                    HelperClass.makeFieldsBlank(groupBox1);
                    CompanyInfo();
                }
                else
                {
                    MessageBox.Show("Error in updating the required operation");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CompanyInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
