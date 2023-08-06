using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Aleatorios
{
    public partial class form_n_a : Form
    {
        public form_n_a()
        {
            InitializeComponent();
        }

        private void form_n_a_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //clear
            lstb1.Items.Clear();
            lstb2.Items.Clear();
            //List Box 1
            Random rnd = new Random();
            int num = rnd.Next();
            lstb1.Items.Add("//-- Numero Aleatorio --//");
            lstb1.Items.Add("-->" + num.ToString());
            lstb1.Items.Add("");
            num = rnd.Next(5);
            lstb1.Items.Add("//-- Numero de 0 a 4 --//");
            lstb1.Items.Add("-->" + num.ToString());
            //list Box 2
            int i,k;
            int[] v = new int[10];
            bool existe;
            lstb2.Items.Add("Numero de 1 a 10 sem repeticao!");
            for (i = 0;i < 10; i++)
            {
                existe = true;
                v[i] = rnd.Next(1,11);
                while (existe)
                    existe = false;
                {
                    for(k = 0; k < i;k++)
                    {
                        if (v[k] == v[i])
                        {
                            existe = false;
                        }
                    }
                    lstb2.Items.Add("-->"+v[i].ToString());
                }
            }
        }
    }
}
