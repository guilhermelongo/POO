using System;

namespace EXPOO1
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto : " + p);

            Console.Write("Digite o numero de produtos a ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados do produto : " + p);

            Console.Write("Digite o numero de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoveProdutos(qte);

            Console.WriteLine("Dados do produto : " + p);





        }
    }
}
