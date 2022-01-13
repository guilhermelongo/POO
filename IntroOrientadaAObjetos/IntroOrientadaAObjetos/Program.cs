using System;

namespace IntroOrientadaAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

           a = new Pessoa();
            b= new Pessoa();

            Console.WriteLine("Digite idade e o nome:");
            a.idade = int.Parse(Console.ReadLine());
            a.nome = Console.ReadLine();

            Console.WriteLine("Digite idade e o nome:");
            b.idade = int.Parse(Console.ReadLine());
            b.nome = Console.ReadLine();

            if (a.idade < b.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + b.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + a.nome);
            
            }
        }
    }
}
