using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            var period = comboBox.Text;

            switch(period)
            {
                case "1 Day":
                    pictureBox.Load("http://ichart.finance.yahoo.com/b?s=" + txtCompany.Text);
                    break;
                case "1 Month":
                    pictureBox.Load("http://chart.finance.yahoo.com/c/1m/d/" + txtCompany.Text);
                    break;
                case "1 Year":
                    pictureBox.Load("http://chart.finance.yahoo.com/c/1y/d/" + txtCompany.Text);
                    break;
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            pictureBox.Image = null;
            comboBox.SelectedIndex = -1;
        }
    }
}
