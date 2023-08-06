using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_Galo
{
    public partial class jogo_do_galo : Form
    {
        public jogo_do_galo()
        {
            InitializeComponent();
        }

        private void jogo_do_galo_Load(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnRecomecar.Enabled = false;
            txt1.Visible = false;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            txt1.Visible = false;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnRecomecar.Enabled = true;
            btnJogar.Enabled = false;
        }
        int x = 0;
        private void jogar_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (x == 0 && btn.Text == "")
            {
                btn.Text = "X";
                x = 1;
            }
            else if(x == 1 && btn.Text == "")
            {
                btn.Text = "O";
                x = 0;
            }
            verificar(x);
        }
        public void verificar(int player)
        {
            //player = 1 -> X
            //player = 0 -> O
            //int i, o, p;
            /*for (i = 1, o = 2, p = 3; i <= 7 && o <= 8 && p <=9 ; i += 3, o += 3,p +=3)
            {}*/
            int b = 0;
            //linhas
            if (btn1.Text == btn2.Text && btn1.Text == btn3.Text && (btn1.Text == "X" || btn1.Text == "O"))
            {
                b = 1;
            }
            else if (btn4.Text == btn5.Text && btn4.Text == btn6.Text && (btn4.Text == "X" || btn4.Text == "O"))
            {
                b = 1;
            }
            else if (btn7.Text == btn8.Text && btn7.Text == btn9.Text && (btn7.Text == "X" || btn7.Text == "O"))
            {
                b = 1;
            }
            //colunas
            else if (btn1.Text == btn4.Text && btn1.Text == btn7.Text && (btn1.Text == "X" || btn1.Text == "O"))
            {
                b = 1;
            }
            else if (btn2.Text == btn5.Text && btn2.Text == btn8.Text && (btn2.Text == "X" || btn2.Text == "O"))
            {
                b = 1;
            }
            else if (btn3.Text == btn6.Text && btn3.Text == btn9.Text && (btn3.Text == "X" || btn3.Text == "O"))
            {
                b = 1;
            }
            //diagonal
            else if (btn1.Text == btn5.Text && btn1.Text == btn9.Text && (btn1.Text == "X" || btn1.Text == "O"))
            {
                b = 1;
            }
            else if (btn3.Text == btn5.Text && btn3.Text == btn7.Text && (btn3.Text == "X" || btn3.Text == "O"))
            {
                b = 1;
            }
            
            //Mensagem
            if (b == 1)
            {
                txt1.Visible = true;
                if (player == 1)
                {
                    txt1.Text = "X Ganhou";
                }
                else
                {
                    txt1.Text = "O Ganhou";
                }
                btnJogar.Enabled = false;
                btnRecomecar.Enabled = true;
                btnRecomecar.Focus();
                b = 0;
            }
        }

        public void btnRecomecar_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btnJogar.Enabled = true;
            btnRecomecar.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
    }
}
