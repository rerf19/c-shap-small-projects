using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomarValores2
{
    public partial class somarValores : Form
    {
        public somarValores()
        {
            InitializeComponent();
        }

        private void somarValores_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double number1, number2, answar;
            //int f;
            if (!(txtNumber1.Text == string.Empty) && !(txtNumber2.Text == string.Empty))
            {
                number1 = double.Parse(txtNumber1.Text);
                number2 = double.Parse(txtNumber2.Text);
                answar = number1 + number2;
                txtAnswar.Text = answar.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if(!(txtNumber1.Text == string.Empty) && !(txtNumber2.Text == string.Empty))
            {
                txtNumber1.Clear();
                txtNumber2.Clear();
                txtAnswar.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
