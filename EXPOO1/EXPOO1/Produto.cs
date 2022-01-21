using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPOO1
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantity)
        {
            Quantidade = Quantidade + quantity;
        } 

        public void RemoveProdutos (int quantity)
        {
            Quantidade =  Quantidade - quantity;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco +" " + Quantidade + " unidades, Total: " + ValorEmEstoque();
        }


    }
}
