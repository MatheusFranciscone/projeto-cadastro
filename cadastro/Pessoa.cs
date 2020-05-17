using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    class Pessoa
    {
        //atributos
        public string nome;
        public string sobrenome;
        public int idade;


        // é um metodo sem retorno (void)
        // e é sem parametro (paramentro fica entre parenteses)
        public void falar() //abre msg.box 
        {
            System.Windows.Forms.MessageBox.Show("Olá! Meu nome é " + nome + " e tenho " + idade + " anos");
        }


        //método com retorno e sem parametro
        public string nomeCompleto()//retorna um string
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }

        //método com retorno e com parametro
        public string Status(int idade)
        {
            string x;

            if (idade >= 18)
            {
                x = "Você é maior de idade";
            } else
            {
                x = "Você é menor de idade";
            }
            return x;
        }
    }
}
