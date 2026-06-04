/* 
Exercício 04:
    Uma escola deseja analisar as notas de uma turma. Crie um programa que:
    - Leia o nome de 10 alunos;
    - Leia a nota de cada aluno (0 a 100);
    - Armazene os nomes em um vetor de strings e as notas em um vetor de inteiros;
    - Crie uma função chamada ClassificarAluno() que receba a nota e retorne:
        Reprovado   (nota < 60)
        Recuperação (60 <= nota < 79)
        Aprovado    (nota >= 80)
    - Exiba um relatório contendo:
        Nome - Nota - Situação;
        Quantos aprovados; 
        Quantos em recuperação; 
        Quantos reprovados; 
        Média geral da turma.
*/

int aprovados = 0, recuperacao = 0, reprovados = 0;
double somaNotas = 0;
string situacao = "";

string ClassificarAluno(int nota) {
    if (nota < 60) {
        reprovados++;
        return "Reprovado(a)";
    } 
    else if (nota <= 79) {
        recuperacao++;
        return "Recuperação";
    } 
    else {
        aprovados++;
        return "Aprovado(a)";
    }
}

Console.WriteLine("========================================");
Console.WriteLine("           CADASTRO DA TURMA           ");
Console.WriteLine("========================================\n");

string[] nomes = new string[10];
Console.WriteLine("> Digite o nome dos 10 alunos (um por linha):");
for (int i = 0; i < 10; i++) {
    Console.Write($"> Aluno {i + 1}: ");
    nomes[i] = Console.ReadLine() ?? "";
}

Console.WriteLine("\n> Digite as notas dos 10 alunos em ordem (separados por espaço):");
string[] notasEntrada = (Console.ReadLine() ?? "").Split(' ');

int[] notas = new int[10];
for (int i = 0; i < 10; i++) {
    notas[i] = int.Parse(notasEntrada[i]);
}

Console.WriteLine("\n========================================");
Console.WriteLine("           RELATÓRIO DA TURMA           ");
Console.WriteLine("========================================\n");
Console.WriteLine("----------------------------------------");
Console.WriteLine("NOME                 NOTA   SITUAÇÃO");
Console.WriteLine("----------------------------------------");
for (int i = 0; i < 10; i++) {
    situacao = ClassificarAluno(notas[i]);
    Console.WriteLine($"{nomes[i],-20} {notas[i],-6} {situacao,-15}");
    somaNotas += notas[i];
}

Console.WriteLine($"\nAprovados = {aprovados}");
Console.WriteLine($"Recuperação = {recuperacao}");
Console.WriteLine($"Reprovados = {reprovados}");
Console.WriteLine($"Média da turma = {somaNotas / 10:F2}");
