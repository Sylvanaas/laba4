using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laaba4
{

    public partial class fMain : Form
    {
       
        public fMain(Bycycle b)
        {
            Bycycle theBycycle = new Bycycle();
            theBycycle = b;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Bycycle theBycycle = new Bycycle();
            theBycycle.brandname = tbName.Text.Trim();
            theBycycle.countryProd = tbСountry.Text.Trim();
            theBycycle.NumOfWheel = int.Parse(tbNum.Text.Trim());
            theBycycle.color = tbColor.Text.Trim();
            theBycycle.size = int.Parse(tbSize.Text.Trim());
            theBycycle.price = int.Parse(tpPrice.Text.Trim());
            DialogResult = DialogResult.OK;
        }
    }
}
