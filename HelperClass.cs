using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillingSystem_RBS
{
    class HelperClass
    {
        public static void makeFieldsBlank(Control ctrl)
        {
            foreach ( Control c in ctrl.Controls)
            {
                if(c is TextBox ) { c.Text = ""; }
                if(c is ComboBox) { c.Text = null; }
            }

        }
    }
}
