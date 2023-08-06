using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intoClassConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosPessoais ob1 = new DadosPessoais();
            ob1.setNome("António Franciso");

            Console.WriteLine(ob1.getNome());
            Console.ReadKey();
        }
    }
}
