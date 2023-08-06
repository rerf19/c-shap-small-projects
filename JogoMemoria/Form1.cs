using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            int nivel = 1;
            Form2 newForm = new Form2(nivel);
            newForm.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            int nivel = 2;
            Form2 newForm = new Form2(nivel);
            newForm.Show();
            this.Visible = true;
        }
        
    }
}
