using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class calcPreco
    {
        private double precoTotal = 0;

        public calcPreco() { }
        public void setPizza(String tamanho,String massa)
        {
            switch (tamanho.ToString())
            {
                case "Individual":
                    switch (massa.ToString())
                    {
                        case "Fina":
                            this.precoTotal = this.precoTotal + 5.90; 
                            break;
                        case "Pan":
                            this.precoTotal = this.precoTotal + 6.85;
                            break;
                        case "Rolling":
                            this.precoTotal = this.precoTotal + 16;
                            break;

                    }
                    break;
                case "Media":
                    switch (massa.ToString())
                    {
                        case "Fina":
                            this.precoTotal = this.precoTotal + 9.55;
                            break;
                        case "Pan":
                            this.precoTotal = this.precoTotal + 10.65;
                            break;
                        case "Rolling":
                            this.precoTotal = this.precoTotal + 16.60;
                            break;

                    }
                    break;
                case "Familiar":
                    switch (massa.ToString())
                    {
                        case "Fina":
                            this.precoTotal = this.precoTotal + 13.40;
                            break;
                        case "Pan":
                            this.precoTotal = this.precoTotal + 14.65;
                            break;
                        case "Rolling":
                            this.precoTotal = this.precoTotal + 17.60;
                            break;

                    }
                    break;
            }
        }
        public void setIngredientes(String tamanho, double temp)
        {
            this.precoTotal = temp;
            switch (tamanho.ToString())
            {
                case "Individual":
                    this.precoTotal = this.precoTotal + 1;
                    break;
                case "Media":
                    this.precoTotal = this.precoTotal + 1.90;
                    break;
                case "Familiar":
                    this.precoTotal = this.precoTotal + 2.30;
                    break;
            }
        }
        public double getPrecoTotal()
        {
            return this.precoTotal;
        }
    }
}
