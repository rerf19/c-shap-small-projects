using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butoens_Dinamicos
{
    public partial class BtnDinamicos : Form
    {
        public BtnDinamicos()
        {
            InitializeComponent();
        }

        private void BtnDinamicos_Load(object sender, EventArgs e)
        {
            criar_btn_dinamicos();
        } 
        private void criar_btn_dinamicos()
        {
            int k = 0,l=0;
            int btn_count = 1;
            for(int i = 1; i <= 9; i++)
            {
                string name = "btnDin" + btn_count;
                Button btn = new Button();
                btn.Name = name;
                btn.Text = name;
                btn.Font = new Font("Georgia", 12);
                btn.Size = new System.Drawing.Size(150, 40);
                if (i == 4 || k == 3)
                {
                    k = k-3;
                    l = l + 45;
                }
                btn.Location = new System.Drawing.Point(k * 150, 130 + l);
                btn.Click += new EventHandler(this.btn_Click);
                Controls.Add(btn);
                btn_count++;
                k++;
            }
        }
        private void btn_Click(object sender,EventArgs e)
        {
            Button dynamicButton = (sender as Button);
            MessageBox.Show("Clicou no" + dynamicButton.Name);
        }
    }
}
