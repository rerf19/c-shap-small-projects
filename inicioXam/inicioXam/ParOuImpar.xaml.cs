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
	public partial class ParOuImpar : ContentPage
	{
		public ParOuImpar ()
		{
			InitializeComponent ();
		}
        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int num=0;
            num = int.Parse(valor.Text);
            string res = "O numero " + valor.Text + " eh ";
            if (num % 2 == 0)
            {
                res += "par";
            }
            else
            {
                res += "impar";
            }
            resultado.Text = res; 
        }
    }
}