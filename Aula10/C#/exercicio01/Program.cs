/* 
Exercício 01:
    Faça um programa para ler os valores da largura e altura de um retângulo e em seguida, mostrar na tela o 
    valor de sua área e perímetro.

    EXEMPLO:
        Entrada:    10
                    5
        Saída:      Área do retângulo: 50 u²                                                                                           
                    Perímetro do retângulo: 30 u
*/

using System;

class Retangulo {
    public double Altura;
    public double Largura;

    public double calcArea() {
        return Altura * Largura;
    }

    public double calcPerimetro() {
        return 2 * (Altura + Largura);
    }

}

class Program
{    
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("   CÁLCULO DE RETÂNGULO   ");
        Console.WriteLine("==========================\n");

        Retangulo retangulo = new Retangulo();

        Console.Write($"> Insira o valor da altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine() ?? "0");

        Console.Write($"> Insira o valor da largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"\nÁrea do retângulo: {retangulo.calcArea():F2} u²");
        Console.WriteLine($"Perímetro do retângulo: {retangulo.calcPerimetro():F2} u");
    }
}
