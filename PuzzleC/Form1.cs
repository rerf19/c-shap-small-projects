using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleC
{
    public partial class formPuzzle : Form
    {
        public formPuzzle()
        {
            InitializeComponent();
        }
        int[] nA = new int[9];
        private void formPuzzle_Load_1(object sender, EventArgs e)
        {
            NumerosAleatorios();
            createPuzzle();
        }
        public void NumerosAleatorios()
        {
            Random aleat = new Random();
            for (int i = 0; i < 9; i++)
            {
                bool existe = true;
                while (existe)
                {
                    existe = false;
                    nA[i] = aleat.Next(1, 10);
                    for (int k = 0; k < i; k++)
                    {
                        if (nA[k] == nA[i])
                            existe = true;
                    }
                }
            }
        }
        private void createPuzzle()
        {
            int numeroPicture = 0, x = 1, y = 40;
            for (int i = 0; i < 9; i++)
            {
                if (x == 4)
                {
                    x = 1;
                    y += 120;
                }
                string name = numeroPicture.ToString();
                PictureBox dynamicPictureB = new PictureBox();
                dynamicPictureB.Name = name;
                dynamicPictureB.Size = new System.Drawing.Size(120, 120);
                dynamicPictureB.Location = new System.Drawing.Point(x * 120, y);
                dynamicPictureB.Tag = nA[i];
                listBox1.Items.Add("/Numero aleatorios/");
                listBox1.Items.Add("" + nA[i]);
                listBox1.Items.Add(x.ToString());
                listBox1.Items.Add(y.ToString());
                dynamicPictureB.Image = Properties.Resources.ResourceManager.GetObject("_"+nA[i]) as Image;
                dynamicPictureB.BackColor = Color.Black;
                dynamicPictureB.SizeMode = PictureBoxSizeMode.StretchImage;
                dynamicPictureB.AllowDrop = true;
                //Events
                dynamicPictureB.DragOver += new DragEventHandler(this.dynamicPictureB_DragOver);
                dynamicPictureB.MouseDown += new MouseEventHandler(this.dynamicPictureB_MouseDown);
                dynamicPictureB.DragDrop += new DragEventHandler(this.dynamicPictureB_DragDrop);
                Controls.Add(dynamicPictureB);
                x++;
                numeroPicture++;
            }
        }
        private void dynamicPictureB_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBoxOrigem = sender as PictureBox;
            //if (pictureBoxOrigem.SelectItems != null)
                DoDragDrop(sender, DragDropEffects.Move);
        }
        private void dynamicPictureB_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void dynamicPictureB_DragDrop(object sender, DragEventArgs e)
        {
            var pictureBoxOrigem = e.Data.GetData(typeof(PictureBox)) as PictureBox;
            var pictureBoxDestino = sender as PictureBox;
            Object copia = pictureBoxOrigem.Image;
            pictureBoxOrigem.Image = pictureBoxDestino.Image;
            pictureBoxDestino.Image = copia as Image;
            /*string copiaTag = pictureBoxDestino.Tag.ToString();
            pictureBoxDestino.Tag = pictureBoxOrigem.Tag;
            pictureBoxOrigem = copiaTag;*/
            int num1 = int.Parse(pictureBoxOrigem.Name);
            int num2 = int.Parse(pictureBoxDestino.Name);
            int copiaTag = nA[num2];
            nA[num2] = nA[num1];
            nA[num1] = copiaTag;
            verifica();
        }
        private void verifica()
        {
            int a = 0;
            for(int i=0;i<8;i++)
            {
                if (nA[i] > nA[i + 1])
                {
                    a++;
                }
            }
            if(a == 8)
            {
                MessageBox.Show("Ganhou");
            }
        }
    }
}

