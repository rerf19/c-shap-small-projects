using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ficheiroXMLinicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Fich = "ficheiro.xml";
            if (File.Exists(Fich) == false)
            {
                XmlTextWriter FicheiroXml = new XmlTextWriter(Fich, System.Text.Encoding.UTF8);
                FicheiroXml.WriteStartDocument(true);
                FicheiroXml.Formatting = Formatting.Indented;
                FicheiroXml.Indentation = 2;
                FicheiroXml.WriteStartElement("associacao");
                FicheiroXml.WriteEndDocument();
                FicheiroXml.Close();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string Fich = "ficheiro.xml";
            XmlDocument FicheiroXML = new XmlDocument();
            FicheiroXML.Load(Fich);
            XmlElement socio = FicheiroXML.CreateElement("aluno");
            XmlAttribute numero = FicheiroXML.CreateAttribute("numero");
            XmlAttribute nome = FicheiroXML.CreateAttribute("nome");
            numero.InnerText = txt1.Text;
            nome.InnerText = txt2.Text;
            socio.Attributes.Append(numero);
            socio.Attributes.Append(nome);
            FicheiroXML.DocumentElement.AppendChild(socio);
            FicheiroXML.Save(Fich);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string Fich = "ficheiro.xml";
            if (File.Exists(Fich) == true)
            {
                dataGrid1.Rows.Clear();
                dataGrid1.Refresh();
                XmlDocument FicheiroXML = new XmlDocument();
                FicheiroXML.Load(Fich);
                foreach (XmlNode no in FicheiroXML.SelectNodes("//socio"))
                {
                    dataGrid1.Rows.Add(no.Attributes[0].Value,no.Attributes[1].Value);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string Fich = "ficheiro.xml";
            if(File.Exists(Fich) == true)
            {
                XmlDocument FicheiroXML = new XmlDocument();
                FicheiroXML.Load(Fich);
                foreach(XmlNode node in FicheiroXML.SelectNodes("/associacao/socio"))
                {
                    node.ParentNode.RemoveChild(node);
                }
                FicheiroXML.Save(Fich);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ficheiro.xml");
            XmlNodeList selecionar = doc.SelectNodes("//socio");
            foreach (XmlNode ficheiro in selecionar)
            {
                if(ficheiro.Attributes[0].Value == txt1.Text)
                {
                    ficheiro.Attributes[1].Value = txt2.Text;
                    break;
                }
            }
            doc.Save("ficheiro.xml");
        }
    }
}
