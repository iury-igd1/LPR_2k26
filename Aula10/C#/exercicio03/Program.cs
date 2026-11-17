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
        Saída:      Nome = Iury (0123AB*9)
                    Média = 55.00
                    Precisa na final = 65.00
*/

using System;

class Aluno {
    public string nome;
    public string matricula;
    public double[] notas = new double[3];

    // Inicializa a identificação do aluno
    public Aluno(string nome, string matricula) {
        this.nome = nome;
        this.matricula = matricula;
    }

    // Calcula a média ponderada: peso 2,5 para cada prova e peso 2 para o trabalho
    public double calcMedia() {
        // Posições: primeira prova, segunda prova e trabalho
        return (notas[0] * 2.5 + notas[1] * 2.5 + notas[2] * 2) / 7.0;
    }
        
    // Retorna a nota necessária na prova final ou zero quando o aluno já está aprovado
    public double final() {
        double media = calcMedia();

        if (media < 60) {
            return 120 - media; // Para aprovação, a média entre a nota atual e a final deve ser pelo menos 60
        }
        else {
            return 0;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("   INFORMAÇÕES DO ALUNO   ");
        Console.WriteLine("==========================\n");

        Console.Write("> Insira o nome do aluno: ");
        string nome = Console.ReadLine() ?? "N/A";

        Console.Write("> Insira a matrícula do aluno: ");
        string matricula = Console.ReadLine() ?? "N/A";

        Aluno aluno = new Aluno(nome, matricula);

        Console.Write("\n> Insira a nota da primeira prova (0 a 100): ");
        aluno.notas[0] = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("> Insira a nota da segunda prova (0 a 100): ");
        aluno.notas[1] = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("> Insira a nota do trabalho (0 a 100): ");
        aluno.notas[2] = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"\nNome = {aluno.nome} ({aluno.matricula})");
        Console.WriteLine($"Média = {aluno.calcMedia():F2}");
        Console.WriteLine($"Precisa na final = {aluno.final():F2}");
    } 
}
