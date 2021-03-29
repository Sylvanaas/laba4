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
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fmain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
         "Припинити роботу", MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bycycle theBycycle = new Bycycle();
            fMain ft = new fMain(theBycycle);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbBycelce.Text += string.Format("назва бренду, країна походження, колво коліс, колір, розмір, ціна", theBycycle.brandname, theBycycle.countryProd, theBycycle.NumOfWheel,
                  theBycycle.color, theBycycle.size, theBycycle.price);
         
            }
            }
    }
}
