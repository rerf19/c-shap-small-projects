using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intoClassConsola
{
    class DadosPessoais
    {
        private String nome;
        private int idade;
        private String local;
        public DadosPessoais() { }
        public DadosPessoais(String nome, int idade, String local)
        {
            this.nome = nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return this.nome;
        }
    }
}
