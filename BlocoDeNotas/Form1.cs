using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocoDeNotas
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.ResetText();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            string local = string.Empty;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files|*.txt;";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = file.FileName;
                local = filePath;
                txt1.Text = File.ReadAllText(local);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            string path = string.Empty;
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = SaveFileDialog1.FileName;
                File.WriteAllText(path, txt1.Text);
            }
        }
    }
}
