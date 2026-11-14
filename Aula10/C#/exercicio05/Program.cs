/* 
Exercício 05:
    Um sistema de vendas precisa representar produtos e pedidos. Cada pedido está associado a um produto.
      - Crie a classe Produto, com os atributos nome e preco;
      - Crie a classe Pedido, com um atributo que armazene um objeto da classe Produto e outro atributo 
        chamado quantidade;
      - No método Main, crie um produto, associe-o a um pedido e exiba o nome do produto, a quantidade e o 
        preço total da compra.
    
    EXEMPLO:
        Saída:      Produto: Xícara de Café                                                                                         
                    Quantidade: 3                                                                                                   
                    Preço total: R$ 31,50 
*/

using System;

class Produto {
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco) {
        Nome = nome;
        Preco = preco;
    }
}

class Pedido {
    public Produto ProdutoComprado;
    public int Quantidade;

    public Pedido(Produto produto, int quantidade) {
        ProdutoComprado = produto;
        Quantidade = quantidade;
    }

    public double preco() {
        return ProdutoComprado.Preco * Quantidade;
    }
}

class Program
{

    static void Main()
    {
        Produto produto = new Produto("Xícara de Café", 10.50);
        Pedido pedido = new Pedido(produto, 3);

        Console.Clear();
        Console.WriteLine("=======================");
        Console.WriteLine("   PREÇO DE PRODUTOS   ");
        Console.WriteLine("=======================\n");

        Console.WriteLine($"Produto: {pedido.ProdutoComprado.Nome}");
        Console.WriteLine($"Quantidade: {pedido.Quantidade}");
        Console.WriteLine($"Preço total: {pedido.preco():F2}");
    }
}
