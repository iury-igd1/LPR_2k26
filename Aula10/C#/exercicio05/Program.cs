/* 
Exercício 05:
    Um sistema de vendas precisa representar produtos e pedidos. Cada pedido está associado a um produto comprado.
      - Crie a classe Produto, com os atributos nome e preco;
      - Crie a classe Pedido, com um atributo que armazene um objeto da classe Produto e outro atributo chamado
        quantidade;
      - No método Main, crie um produto, associe-o a um pedido e exiba o nome do produto, a quantidade e o preço 
        total da compra.
*/

using System;

class Program
{
    class Produto {
        public string Nome = "";
        public double Preco = 0;
    }
    class Pedido {
        public Produto Produto = new Produto();
        public int Quantidade = 0;
    }

    static void Main()
    {
        Produto produto = new Produto { 
            Nome = "Xícara de Café", 
            Preco = 10.50 
        };
        Pedido pedido = new Pedido { 
            Produto = produto, 
            Quantidade = 3
        };

        Console.Clear();
        Console.WriteLine("=======================");
        Console.WriteLine("   PREÇO DE PRODUTOS   ");
        Console.WriteLine("=======================\n");

        Console.WriteLine($"Produto: {pedido.Produto.Nome}");
        Console.WriteLine($"Quantidade: {pedido.Quantidade}");
        Console.WriteLine($"Preço total: {pedido.Produto.Preco * pedido.Quantidade:C}");
    }
}