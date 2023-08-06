using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesBasicas
{
    public partial class OprBasicas : Form
    {
        public OprBasicas()
        {
            InitializeComponent();
        }

        private void OprBasicas_Load(object sender, EventArgs e)
        {
            txtAnwser.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            if (!(txtNumber1.Text == string.Empty) && !(txtNumber2.Text == string.Empty))
            {
                num1 = double.Parse(txtNumber1.Text);
                num2 = double.Parse(txtNumber2.Text);
                if (rdSoma.Checked)
                {
                    res = num1 + num2;
                    txtAnwser.Text = res.ToString();
                }
                else if (rdSubtrair.Checked)
                {
                    res = num1 - num2;
                    txtAnwser.Text = res.ToString();
                }
                else if (rdMultiplicar.Checked)
                {
                    res = num1 * num2;
                    txtAnwser.Text = res.ToString();
                }
                else
                {
                    res = num1 / num2;
                    txtAnwser.Text = res.ToString();
                }
                btnLimpar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtAnwser.Clear();
            btnCalcular.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
