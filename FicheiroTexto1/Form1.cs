using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //tive de adicionar esta biblioteca;

namespace FicheiroTexto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string path = @"C:\Users\Rodrigo Ferreira\Desktop\Tasks\Programming\FicheiroTexto1\bin\Debug\Texto.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fichOut = new FileStream("Texto.txt", FileMode.Create);
            fichOut.Close();
        }

        private void btn1_Click(object sender, EventArgs e) // Adicionar
        {
            try
            {
                FileStream fichOut = new FileStream("Texto.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fichOut);
                int num;
                string nome = "";
                num = int.Parse(txt1.Text);
                nome = txt2.Text;
                writer.WriteLine(num);
                writer.WriteLine(nome);
                for (int i = 0; i < 5; i++)
                {
                    writer.Write("Palavra" + i + " ");
                }
                writer.WriteLine("");
                for (int i = 0; i < 5; i++)
                {
                    writer.WriteLine("Linha" + i + " ");
                }
                writer.Flush();
                writer.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                StreamReader reader = new StreamReader("Texto.txt");
                string linha = "";
                do
                {
                    linha = reader.ReadLine();
                    if (linha != null)
                    {
                        listBox1.Items.Add(linha);
                    }
                } while (linha != null);
                reader.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }
    }
}
