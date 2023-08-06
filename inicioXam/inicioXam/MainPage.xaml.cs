using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace inicioXam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ParOuImparButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParOuImpar());
        }
        private void MaiorOuMenorButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaiorOuMenor());
        }
    }
}
