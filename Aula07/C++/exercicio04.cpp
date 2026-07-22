/* 
Exercício 04:
    Uma escola deseja analisar as notas de uma turma. Crie um programa que:
        - Leia o nome de 10 alunos;
        - Leia a nota de cada aluno (0 a 100);
        - Armazene os nomes em um vetor de strings e as notas em um vetor de inteiros;
        - Crie uma função chamada ClassificarAluno() que receba a nota e retorne:
            Reprovado   (nota < 60)
            Recuperação (60 <= nota <= 79)
            Aprovado    (nota >= 80)
        - Exiba um relatório contendo:
            Nome - Nota - Situação;
            Quantos aprovados; 
            Quantos em recuperação; 
            Quantos reprovados; 
            Média geral da turma.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>
#include <vector>

using namespace std;

int aprovados = 0, recuperacao = 0, reprovados = 0;

string ClassificarAluno(int nota) { // Classifica a nota do aluno e incrementa o contador correspondente
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

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "========================================" << endl;
    cout << "           CADASTRO DA TURMA           " << endl;
    cout << "========================================\n" << endl;

    vector<string> nomes(10);
    // Lê o nome dos 10 alunos
    cout << "> Digite o nome dos 10 alunos (um por linha):" << endl;
    for (int i = 0; i < 10; i++) {
        cout << "> Aluno " << (i + 1) << ": ";
        getline(cin, nomes[i]);
    }

    // Lê as notas dos 10 alunos, na mesma ordem dos nomes
    cout << "\n> Digite as notas dos 10 alunos em ordem (separados por espaço):" << endl;
    vector<int> notas(10);
    for (int i = 0; i < 10; i++) {
        cin >> notas[i];
    }

    cout << "\n========================================" << endl;
    cout << "           RELATÓRIO DA TURMA           " << endl;
    cout << "========================================\n" << endl;
    cout << "----------------------------------------" << endl;
    cout << "NOME                 NOTA   SITUAÇÃO" << endl;
    cout << "----------------------------------------" << endl;

    double somaNotas = 0;
    // Monta o relatório linha a linha, classificando cada aluno e somando as notas
    for (int i = 0; i < 10; i++) {
        string situacao = ClassificarAluno(notas[i]);
        cout << left << setw(20) << nomes[i] << " " << setw(6) << notas[i] << " " << setw(15) << situacao << endl;
        somaNotas += notas[i];
    }

    cout << "\nAprovados = " << aprovados << endl;
    cout << "Recuperação = " << recuperacao << endl;
    cout << "Reprovados = " << reprovados << endl;
    cout << "Média da turma = " << fixed << setprecision(2) << (somaNotas / 10) << endl;
}
