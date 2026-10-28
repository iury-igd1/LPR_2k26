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

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
}