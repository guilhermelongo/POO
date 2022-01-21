using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOrientadaAObjetos
{
    public class Pessoa
    {

        public int idade;
        public string nome;
        public int atual;
        public int nascimento;


        public double Calc()
        {

            nascimento = atual - idade;
            return nascimento;
            

        }



    }
}
