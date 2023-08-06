using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool entrar = true;
        double temp;
        string tamanho;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            calcPreco c1 = new calcPreco();
            if (entrar)
            {
                entrar = false;
                c1.setPizza(cboTamanho.Text, cboMassa.Text);
                temp = c1.getPrecoTotal();
                tamanho = cboTamanho.Text;
                if (cboIngredientes.Text != "")
                {
                    c1.setIngredientes(cboTamanho.Text,temp);
                    dgvIngredientes.Rows.Add(cboIngredientes.Text);
                }
                lblTotal.Text = c1.getPrecoTotal().ToString() + " euros";
            }
            else
            {
                if(cboIngredientes.Text != "")
                {
                    c1.setIngredientes(tamanho,temp);
                    temp = c1.getPrecoTotal();
                    dgvIngredientes.Rows.Add(cboIngredientes.Text);
                    lblTotal.Text = c1.getPrecoTotal().ToString() + " euros";
                }
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            temp = 0;
            dgvIngredientes.Rows.Clear();
            lblTotal.Text = "";
            entrar = true;
            cboIngredientes.Text = "";
            cboMassa.Text = "";
            cboTamanho.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
