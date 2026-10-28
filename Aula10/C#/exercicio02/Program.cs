/* 
Exercício 02:
    Faça um programa para ler os dados de um funcionário (nome, salário bruto e imposto). 
    A classe funcionário deve conter os seguintes métodos:
      - Mostrar os dados do funcionário (nome e salário líquido);
      - Aumentar o salário do funcionário com base em uma porcentagem dada.
    Tabela de Imposto:
      - 10% para salários de até 2000;
      - 15% para salários de até 3000;
      - 20% para salários superiores a 3000.

    EXEMPLO:
        Entrada:    Iury
                    2500
        Saída:      Nome do funcionário: Iury
                    Salário líquido: R$ 2125,00
*/

using System;

class Program
{
    public class Funcionario {
        public string Nome = "";
        public double SalarioBruto;
        public double Imposto;

        public double calcSalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void aumentarSalario(double porcentagem) {
            SalarioBruto += SalarioBruto * porcentagem / 100;
        }
    }

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("   INFORMAÇÕES DO FUNCIONÁRIO   ");
        Console.WriteLine("================================\n");

        Console.Write($"> Insira o nome do funcionário: ");
        string nome = Console.ReadLine() ?? "N/A";

        Console.Write($"> Insira o salário bruto do funcionário: ");
        double salarioBruto = double.Parse(Console.ReadLine() ?? "0");

        Funcionario funcionario = new Funcionario();
        funcionario.Nome = nome;
        funcionario.SalarioBruto = salarioBruto;
        if (salarioBruto <= 2000) {
            funcionario.Imposto = salarioBruto * 0.10;
        } 
        else if (salarioBruto <= 3000) {
            funcionario.Imposto = salarioBruto * 0.15;
        } 
        else {
            funcionario.Imposto = salarioBruto * 0.20;
        }

        Console.WriteLine($"\nNome do funcionário: {funcionario.Nome}");
        Console.WriteLine($"Salário líquido: R$ {funcionario.calcSalarioLiquido():F2}");

        Console.Write($"\n> Deseja aumentar o salário do funcionário? (s/n): ");
        string resposta = Console.ReadLine() ?? "n";
        if (resposta.ToLower() == "s") {
            Console.Write($"> Insira a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine() ?? "0");
            funcionario.aumentarSalario(porcentagem);
            Console.WriteLine($"\nSalário após aumento: R$ {funcionario.calcSalarioLiquido():F2}");
        }
    }
}