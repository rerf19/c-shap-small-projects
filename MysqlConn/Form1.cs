using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MysqlConn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inserirCombo();
        }

        

        private void inserirCombo()
        {
            const string mysql = "datasource=127.0.0.1;port=3306;username=root;password=;database=testeC#";
            MySqlConnection conn = new MySqlConnection(mysql);
            string query = "SELECT * FROM pessoas";
            MySqlCommand pessoa = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = pessoa.ExecuteReader();
                if (reader.HasRows)
                {
                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["PrimeiroNome"].ToString() + " " + reader["UltimoNome"].ToString() + " - " + reader["Morada"].ToString() + ", " + reader["Cidade"].ToString());
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Occoreu um erro e nao foi possveil apresentar a lista de pessoas!");
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCidade.Text == "" || txtPrimeiroNome.Text == "" || txtUltimoNome.Text == "" || txtMorada.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    const string mysql = "datasource=127.0.0.1;port=3306;username=root;password=;database=testeC#";
                    MySqlConnection conn = new MySqlConnection(mysql);
                    string insert = "INSERT INTO pessoas (PrimeiroNome,UltimoNome,Morada,Cidade) VALUES ("+ txtPrimeiroNome.Text + ","+ txtUltimoNome.Text + ","+ txtCidade.Text + ","+ txtMorada.Text + ")";
                    MySqlCommand inserir = new MySqlCommand(insert, conn);
                    conn.Open();
                    inserir.ExecuteNonQuery();
                    conn.Close();
                    inserirCombo();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel inserir a pessoa na BD!");
            }
        }
    }
}
