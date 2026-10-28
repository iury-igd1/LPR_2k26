/* 
Exercício 08:
    Crie um sistema onde Aluno e Turma possuem uma relação N-N.
      - Cada aluno pode estar matriculado em várias turmas, e cada turma pode ter vários alunos;
      - Crie as classes Aluno, Turma, e uma classe intermediária Matricula;
      - Em Aluno e Turma, crie listas de Matricula para associar um aluno a uma turma;
      - Implemente métodos em Aluno e Turma para adicionar uma nova Matricula;
      - Em Matricula, inclua um atributo para registrar a data da matrícula;
      - Adicione uma lógica para verificar se um Aluno já está matriculado em uma Turma antes de permitir uma 
        nova Matricula;
      - Implemente um método em Turma para retornar a lista de todos os alunos matriculados.
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