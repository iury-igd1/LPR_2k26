/* 
Exercício 01:
    Faça um programa para ler os valores da largura e altura de um retângulo e em seguida, mostrar na tela o 
    valor de sua área e perímetro.

    EXEMPLO:
        Entrada:    10
                    5
        Saída:      Área = 50.00 u.a.                                                                                          
                    Perímetro = 30.00 u.
*/

using System;

class Retangulo {
    public double altura;
    public double largura;

    // Calcula a área multiplicando a altura pela largura
    public double calcArea() {
        return altura * largura;
    }

    // Calcula o perímetro somando os quatro lados do retângulo
    public double calcPerimetro() {
        return 2 * (altura + largura);
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

        Retangulo retangulo = new Retangulo(); // Cria o retângulo que receberá as dimensões informadas pelo usuário

        Console.Write("> Insira a altura do retângulo: ");
        retangulo.altura = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("> Insira a largura do retângulo: ");
        retangulo.largura = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"\nÁrea = {retangulo.calcArea():F2} u.a.");
        Console.WriteLine($"Perímetro = {retangulo.calcPerimetro():F2} u.");
    }
}
