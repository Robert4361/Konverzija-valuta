using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konverzija_valuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Currency currency1 = CurrencyFactory.getCurrency(cmbFrom.Text);
            Currency currency2 = CurrencyFactory.getCurrency(cmbTo.Text);

            double convertedAmount = currency1.ConvertTo(currency2, Convert.ToInt32(txtAmount.Text));

            ShowResult(convertedAmount);
        }

        internal void ShowResult(double convertedAmount)
        {
            txtConverted.Text = convertedAmount.ToString();
        }
    }
}
