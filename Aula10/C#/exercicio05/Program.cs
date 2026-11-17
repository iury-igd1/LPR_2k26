/* 
Exercício 05:
    Um sistema de vendas precisa representar produtos e pedidos. Cada pedido está associado a um produto.
      - Crie a classe Produto, com os atributos nome e preco;
      - Crie a classe Pedido, com um atributo que armazene um objeto da classe Produto e outro atributo 
        chamado quantidade;
      - No método Main, crie um produto, associe-o a um pedido e exiba o nome do produto, a quantidade e o 
        preço total da compra.
    
    EXEMPLO:
        Saída:      Produto = Xícara de Café                                                                                         
                    Quantidade = 3                                                                                                   
                    Preço total = R$ 31.50 
*/

using System;

class Produto {
    public string nome;
    public double preco;

    // Inicializa o produto com nome e preço unitário
    public Produto(string nome, double preco) {
        this.nome = nome;
        this.preco = preco;
    }
}

class Pedido {
    public Produto produtoComprado;
    public int quantidade;

    // Associa o produto ao pedido e define a quantidade comprada
    public Pedido(Produto produto, int quantidade) {
        produtoComprado = produto;
        this.quantidade = quantidade;
    }

    // Calcula o total da compra multiplicando o preço unitário pela quantidade
    public double preco() {
        return produtoComprado.preco * quantidade;
    }
}

class Program
{

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=======================");
        Console.WriteLine("   PREÇO DE PRODUTOS   ");
        Console.WriteLine("=======================\n");

        Produto produto = new Produto("Xícara de Café", 10.50);
        Pedido pedido = new Pedido(produto, 3);

        Console.WriteLine($"Produto = {pedido.produtoComprado.nome}");
        Console.WriteLine($"Quantidade = {pedido.quantidade}");
        Console.WriteLine($"Preço total = R$ {pedido.preco():F2}");
    }
}
