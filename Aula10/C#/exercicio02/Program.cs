/* 
Exercício 02:
    Faça um programa para ler os dados de um funcionário (nome e salário bruto). 
    A classe funcionário deve conter os seguintes métodos:
      - Mostrar os dados do funcionário (nome e salário líquido);
      - Aumentar o salário do funcionário com base em uma porcentagem dada.
    Tabela de Imposto:
      - 10% para salários de até 2000;
      - 15% para salários de até 3000;
      - 20% para salários superiores a 3000.

    EXEMPLO:
        Entrada:    Iury
                    2400
        Saída:      Nome do funcionário: Iury
                    Salário líquido: R$ 2040,00
        Entrada:    s
                    10
        Saída:      Após aumento:
                    Nome do funcionário: Iury                                     
                    Salário líquido: R$ 2244,00 
*/

using System;

class Funcionario {
    public string Nome;
    public double SalarioBruto;

    public Funcionario(string nome, double salarioBruto) {
        Nome = nome;
        SalarioBruto = salarioBruto;
    }

    public double calcImposto() {
        if (SalarioBruto <= 2000) {
            return SalarioBruto * 0.1;
        }
        else if (SalarioBruto <= 3000) {
            return SalarioBruto * 0.15;
        }
        else {
            return SalarioBruto * 0.2;
        }
    }

    public void dados() {
        double salarioLiquido = SalarioBruto - calcImposto();
        Console.WriteLine($"\nNome do funcionário: {Nome}");
        Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");
    }

    public void aumentarSalario(double porcentagem) {
        SalarioBruto += SalarioBruto * porcentagem / 100;
    }
}

class Program
{   
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("   INFORMAÇÕES DO FUNCIONÁRIO   ");
        Console.WriteLine("================================\n");

        Console.Write($"> Insira o nome do funcionário: ");
        string nome = Console.ReadLine() ?? "N/A";

        Console.Write($"> Insira o salário bruto do funcionário: ");
        double salario = double.Parse(Console.ReadLine() ?? "0");

        Funcionario funcionario = new Funcionario(nome, salario);
        funcionario.dados();

        Console.Write($"\n> Deseja aumentar o salário do funcionário? (s/n): ");
        string resposta = Console.ReadLine() ?? "n";
        if (resposta.ToLower() == "s") {
            Console.Write($"> Insira a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine() ?? "0");
            funcionario.aumentarSalario(porcentagem);
            Console.Write($"\nApós aumento:");
            funcionario.dados();
        }
    }
}
