using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idades
{
    public partial class FormIdades : Form
    {
        public FormIdades()
        {
            InitializeComponent();
        }

        private void FormIdades_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 500);
            txtMDI.ReadOnly = true;
            txtPMN.ReadOnly = true;
            txtPMV.ReadOnly = true;
            txtTDP.ReadOnly = true;
            txtSaida.Visible = false;
        }
        int idade, count = 0, maior = -1, menor = 200, count2 = 0;
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(!(txtIdade.Text == string.Empty))
            {
                txtSaida.Visible = false;
                bool valida = int.TryParse(txtIdade.Text, out idade);
                if (valida && idade>0)
                {
                    count++;
                    count2 = count2 + idade;
                    txtMDI.Text = ((double)count2/count).ToString();
                    txtTDP.Text = count.ToString();
                    if (idade < menor) menor = idade;txtPMN.Text = menor.ToString();
                    if (idade > maior) maior = idade;txtPMV.Text = maior.ToString();
                }
                else
                {
                    txtSaida.Text = "Tem de ser um numero mairo de 0!";
                    txtSaida.Visible = true;
                }
            }
            else
            {
                txtSaida.Text = "Tem de Inserir Um Numero!";
                txtSaida.Visible = true;
            }
        }
    }
}
