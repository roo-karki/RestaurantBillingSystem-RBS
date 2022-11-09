using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillingSystem_RBS
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }
        public int KOTId;
        private void BillingForm_Load(object sender, EventArgs e)
        {
             this.BillingTableTableAdapter.Fill(this.BillingDataSet.BillingTable, KOTId);
            this.OrderTableTableAdapter.Fill(this.BillingDataSet.OrderTable, KOTId);
            this.CompanyInfoTableTableAdapter.Fill(this.BillingDataSet.CompanyInfoTable);
            this.reportViewer1.RefreshReport();
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
