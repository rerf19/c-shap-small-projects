using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class Form2 : Form
    {
        int nivel = 0;
        int niveln;
        public Form2(int nivelForm1)
        {
            InitializeComponent();
            nivel = nivelForm1;
            if (nivel == 1) niveln = 8;
            else niveln = 12;
            Form2_Load();
        }
        private void Form2_Load()
        {
            gerarNumeros();
            gerarPB();
        }
        int[] nA = new int[13];
        private void gerarNumeros()
        {
            for(int i = 0; i < niveln; i++)
            {
                nA[i] = 0;
            }
            Random rnd = new Random();
            if(nivel == 1)
            {
                for(int i = 0; i < niveln/2; i++)
                {
                    int count=0;
                    while (count != 2)
                    {
                        int n = rnd.Next(8);
                        if (nA[n] == 0)
                        {
                            nA[n] = i + 1;
                            count++;
                        }
                    }
                }
                for(int i = 0; i < 8; i++)
                {
                    listBox1.Items.Add(nA[i].ToString());
                }
            }
            if (nivel == 2)
            {
                for (int i = 0; i < niveln / 2; i++)
                {
                    int count = 0;
                    while (count != 2)
                    {
                        int n = rnd.Next(12);
                        if (nA[n] == 0)
                        {
                            nA[n] = i + 1;
                            count++;
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    listBox1.Items.Add(nA[i].ToString());
                }
            }
        }

        private async void gerarPB()
        {
            int count = 0, x = 100, y = 100;
            listBox1.Items.Add("NIVELn: " + niveln.ToString());
            for (int i = 1; i <= niveln; i++)
            {
                count++;
                PictureBox pb = new PictureBox();
                string name = i.ToString();
                pb.Name = name;
                pb.Size = new System.Drawing.Size(100, 100);
                pb.Location = new System.Drawing.Point(x, y);
                pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pb.Image = Properties.Resources.ResourceManager.GetObject("_" + nA[i - 1]) as Image;
                pb.Click += new EventHandler(this.pb_Click);
                x += 100;
                if (i % 4 == 0)
                {
                    x = 100;
                    y += 100;
                }
                Controls.Add(pb);
            }
            await Task.Delay(2000);
            virar(this.Controls);
        }
        private void virar(Control.ControlCollection controles)
        {
            foreach(var ctrl in controles)
            {
                PictureBox b = ctrl as PictureBox;
                if (b != null)
                {
                    b.Image = Properties.Resources.ResourceManager.GetObject("_7") as Image;
                }
            }
        }
        int count = 0, pb1 = 0, pb2 = 0, win = 0;
        PictureBox pic;
        private async void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (sender as PictureBox);
            
            int name = int.Parse(pb.Name);
            pb.Image = Properties.Resources.ResourceManager.GetObject("_" + nA[name - 1]) as Image;
            if(count == 0)
            {
                pic = pb;
                pb1 = nA[name - 1];
                count++;
                pb.Enabled = false;
            }
            else
            {
                pb2 = nA[name - 1];
                count++;
                pic.Enabled = false;
            }
            if (count == 2)
            {
                await Task.Delay(300);
                if (pb1 != pb2)
                {
                    pb.Image = Properties.Resources.ResourceManager.GetObject("_7") as Image;
                    pic.Image = Properties.Resources.ResourceManager.GetObject("_7") as Image;
                    pb.Enabled = true;
                    pic.Enabled = true;
                }
                else
                {
                    win += 1;
                    pb.Enabled = false;
                    pic.Enabled = false;
                }
                count = 0;
            }
            if (nivel == 1)
            {
                if(win == 4)
                {
                    MessageBox.Show("Ganhou");
                }
            }
            else
            {
                if(win == 6)
                {
                    MessageBox.Show("Ganhou");
                }
            }
        }
    }
}
