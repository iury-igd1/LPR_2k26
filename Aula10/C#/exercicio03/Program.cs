/* 
Exercício 03:
    Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. Cada objeto dessa
    classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho. 
    Escreva os seguintes métodos para esta classe:
      - Media: calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2);
      - Final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for para a final).
        O aluno vai pra final se sua média for menor que 60.

    EXEMPLO:
        Entrada:    Iury
                    0123AB*9
                    40
                    50
                    80
        Saída:      Nome do aluno: Iury
                    Matrícula: 0123AB*9
                    Média: 55,00
                    Precisa para a final: 5,00
*/

using System;

class Program
{
    public class Aluno {
        public string Nome = "";
        public string Matricula = "";
        public double[] Notas = new double[3];

        public double calcMedia() {
            return (Notas[0] * 2.5 + Notas[1] * 2.5 + Notas[2] * 2) / 7;
        }
        public double final(double media) {
            if (media < 60) {
                return 60 - media;
            }
            return 0;
        }
    }

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("   INFORMAÇÕES DO ALUNO   ");
        Console.WriteLine("==========================\n");

        Console.Write($"> Insira o nome do aluno: ");
        string nome = Console.ReadLine() ?? "N/A";

        Console.Write($"> Insira a matrícula do aluno: ");
        string matricula = Console.ReadLine() ?? "N/A";

        Aluno aluno = new Aluno();
        aluno.Nome = nome;
        aluno.Matricula = matricula;

        Console.Write($"\n> Insira a nota da primeira prova (0 a 100): ");
        aluno.Notas[0] = double.Parse(Console.ReadLine() ?? "0");

        Console.Write($"> Insira a nota da segunda prova (0 a 100): ");
        aluno.Notas[1] = double.Parse(Console.ReadLine() ?? "0");

        Console.Write($"> Insira a nota do trabalho (0 a 100): ");
        aluno.Notas[2] = double.Parse(Console.ReadLine() ?? "0");

        double media = aluno.calcMedia();
        double final = aluno.final(media);

        Console.WriteLine($"\nNome do aluno: {aluno.Nome}");
        Console.WriteLine($"Matrícula: {aluno.Matricula}");
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Precisa para a final: {final:F2}");
    } 
}