using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inicioXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaiorOuMenor : ContentPage
    {
        public MaiorOuMenor()
        {
            InitializeComponent();
        }
        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int valor1 = 0,valor2 = 0;
            string res;
            valor1 = int.Parse(num1.Text);
            valor2 = int.Parse(num2.Text);
            if(valor1 > valor2)
            {
                res = "O Numero 1 eh o maior!";
            }
            else
            {
                res = "O Numero 2 eh o maior!";
            }
            resultado.Text = res;
        }
    }
}