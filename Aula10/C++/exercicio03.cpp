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

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

class Aluno {
    public:
    string nome;
    string matricula;
    double notas[3];

    // Inicializa a identificação do aluno
    Aluno(string nome, string matricula) {
        this->nome = nome;
        this->matricula = matricula;
    }

    // Calcula a média ponderada: peso 2,5 para cada prova e peso 2 para o trabalho
    double calcMedia() {
        // Posições: primeira prova, segunda prova e trabalho
        return (notas[0] * 2.5 + notas[1] * 2.5 + notas[2] * 2) / 7.0;
    }

    // Retorna a nota necessária na prova final ou zero quando o aluno já está aprovado
    double final() {
        double media = calcMedia();

        if (media < 60) {
            return 120 - media; // Para aprovação, a média entre a nota atual e a final deve ser pelo menos 60
        }
        else {
            return 0;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "==========================" << endl;
    cout << "   INFORMAÇÕES DO ALUNO   " << endl;
    cout << "==========================\n" << endl;

    string nome, matricula;

    cout << "> Insira o nome do aluno: ";
    getline(cin, nome);

    cout << "> Insira a matrícula do aluno: ";
    getline(cin, matricula);

    Aluno aluno(nome, matricula);

    cout << "\n> Insira a nota da primeira prova (0 a 100): ";
    cin >> aluno.notas[0];

    cout << "> Insira a nota da segunda prova (0 a 100): ";
    cin >> aluno.notas[1];

    cout << "> Insira a nota do trabalho (0 a 100): ";
    cin >> aluno.notas[2];

    cout << fixed << setprecision(2);
    cout << "\nNome = " << aluno.nome << " (" << aluno.matricula << ")" << endl;
    cout << "Média = " << aluno.calcMedia() << endl;
    cout << "Precisa na final = " << aluno.final() << endl;
}
