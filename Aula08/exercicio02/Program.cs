/* 
Exercício 02:
    Defina uma struct Produto que contenha os seguintes campos: 
        Nome, Codigo, Preco e Quantidade. 
    
    Crie um programa que permita ao usuário inserir dados de 3 produtos e, em seguida, exiba o valor total 
    em estoque (considerando o preço e a quantidade de cada produto).
*/

using System;

class Program
{
    struct Produto
    {
    public string Nome;
    public string Codigo;
    public double Preco;
    public int Quantidade;
    }
    
    static void Main()
    {
        Produto[] listaProdutos = new Produto[3];
        double total = 0;

        Console.WriteLine("==========================");
        Console.WriteLine("   CADASTRO DE PRODUTOS   ");
        Console.WriteLine("==========================\n");

        for (int i = 0; i < 3; i++) { // Lê os dados de cada um dos 3 produtos e já acumula o valor total em estoque
            Console.Write("> Informe o nome do Produto " + (i + 1) + ": ");
            listaProdutos[i].Nome = Console.ReadLine() ?? "";

            Console.Write("> Informe o código do Produto " + (i + 1) + ": ");
            listaProdutos[i].Codigo = Console.ReadLine() ?? "";

            Console.Write("> Informe o preço do Produto " + (i + 1) + ": ");
            listaProdutos[i].Preco = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("> Informe a quantidade do Produto " + (i + 1) + " no estoque: ");
            listaProdutos[i].Quantidade = int.Parse(Console.ReadLine() ?? "0");

            total += listaProdutos[i].Preco * listaProdutos[i].Quantidade;

            Console.WriteLine();
        }

        Console.WriteLine("Produtos cadastrados:");
        Console.WriteLine("[1] " + listaProdutos[0].Nome);
        Console.WriteLine("[2] " + listaProdutos[1].Nome);
        Console.WriteLine("[3] " + listaProdutos[2].Nome);
        Console.WriteLine();

        Console.WriteLine("Valor total em estoque = R$ " + total.ToString("F2"));
    }
}