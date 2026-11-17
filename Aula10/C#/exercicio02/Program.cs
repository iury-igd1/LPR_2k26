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
        Saída:      Nome = Iury
                    Salário líquido = R$ 2040.00
        Entrada:    s
                    10
        Saída:      Após aumento:
                    Nome = Iury                                     
                    Salário líquido = R$ 2244.00 
*/

using System;

class Funcionario {
    public string nome;
    public double salarioBruto;

    // Inicializa o funcionário com nome e salário bruto
    public Funcionario(string nome, double salarioBruto) {
        this.nome = nome;
        this.salarioBruto = salarioBruto;
    }

    // Calcula o imposto aplicando a alíquota correspondente ao salário bruto
    public double calcImposto() {
        if (salarioBruto <= 2000) {
            return salarioBruto * 0.1;
        }
        else if (salarioBruto <= 3000) {
            return salarioBruto * 0.15;
        }
        else {
            return salarioBruto * 0.2;
        }
    }

    // Exibe o nome e o salário líquido após descontar o imposto
    public void dados() {
        double salarioLiquido = salarioBruto - calcImposto();
        Console.WriteLine($"\nNome = {nome}");
        Console.WriteLine($"Salário líquido = R$ {salarioLiquido:F2}");
    }

    // Acrescenta ao salário bruto o percentual de aumento informado
    public void aumentarSalario(double porcentagem) {
        salarioBruto += salarioBruto * porcentagem / 100;
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

        Console.Write("> Insira o nome do funcionário: ");
        string nome = Console.ReadLine() ?? "N/A";

        Console.Write("> Insira o salário bruto do funcionário: ");
        double salario = double.Parse(Console.ReadLine() ?? "0");

        Funcionario funcionario = new Funcionario(nome, salario);
        funcionario.dados();

        Console.Write("\n> Deseja aumentar o salário do funcionário? (s/n): ");
        string resposta = Console.ReadLine() ?? "n";
        
        if (resposta.ToLower() == "s") {
            Console.Write("> Insira a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine() ?? "0");
            
            funcionario.aumentarSalario(porcentagem);
            Console.Write("\nApós aumento:");
            funcionario.dados();
        }
    }
}
