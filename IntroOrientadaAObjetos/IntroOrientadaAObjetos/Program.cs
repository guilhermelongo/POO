using System;

namespace IntroOrientadaAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

           a = new Pessoa();
            

            Console.WriteLine("Digite idade:");
            a.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite o ano atual:");
            a.atual = int.Parse(Console.ReadLine());

            

            double calculando = a.Calc();
            Console.WriteLine(calculando);

        }
    }
}
