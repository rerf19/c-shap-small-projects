using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuadas
{
    public partial class FormTabuada : Form
    {
        public FormTabuada()
        {
            InitializeComponent();
        }

        private void FormTabuada_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 500);
        }

        private void cbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = int.Parse(cboNumero.Text);
            lstTabuada.Items.Clear();
            for(int i = 1; i <= 10; i++)
            {
                string tabuada = string.Format("{0} x {1} = {2}", numero, i, numero * i);
                lstTabuada.Items.Add(tabuada);        
            }
        }
    }
}
