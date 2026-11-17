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
#include <list>

using namespace std;

class Aluno; // Declara os tipos usados pelos ponteiros da classe Matricula
class Turma;

class Matricula {
    public:
    // Guarda os endereços do aluno e da turma associados à matrícula
    Aluno* aluno;
    Turma* turma;
    string data;

    // Registra o aluno, a turma e a data que compõem a matrícula
    Matricula(Aluno* aluno, Turma* turma, string data) {
        this->aluno = aluno;
        this->turma = turma;
        this->data = data;
    }
};

class Aluno {
    public:
    string nome;
    list<Matricula> matriculas;

    // Inicializa o nome do aluno
    Aluno(string nome) {
        this->nome = nome;
    }

    // A implementação fica após a definição de Turma, pois utiliza seus atributos
    void adicionarMatricula(Turma& turma, string data);
};

class Turma {
    public:
    string nome;
    list<Matricula> matriculas;

    // Inicializa o nome da turma
    Turma(string nome) {
        this->nome = nome;
    }

    // Encaminha o cadastro ao aluno para reutilizar a verificação de matrícula duplicada
    void adicionarMatricula(Aluno& aluno, string data) {
        aluno.adicionarMatricula(*this, data);
    }

    // Monta e retorna a lista dos alunos associados às matrículas desta turma
    list<Aluno*> listarAlunos() {
        list<Aluno*> alunos;

        for (Matricula matricula : matriculas) {
            alunos.push_back(matricula.aluno);
        }

        return alunos;
    }
};

void Aluno::adicionarMatricula(Turma& turma, string data) {
    // Compara os endereços das turmas para impedir uma matrícula duplicada
    for (Matricula matricula : matriculas) {
        if (matricula.turma == &turma) {
            cout << nome << " já está matriculado em " << turma.nome << "." << endl;
            return;
        }
    }

    Matricula nova(this, &turma, data);

    // Registra a associação nas coleções do aluno e da turma
    matriculas.push_back(nova);
    turma.matriculas.push_back(nova);
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "===========================" << endl;
    cout << "   SISTEMA DE MATRÍCULAS   " << endl;
    cout << "===========================\n" << endl;

    Aluno iury("Iury");
    Aluno jose("José");

    Turma lpr("LPR");
    Turma seb("SEB");

    iury.adicionarMatricula(lpr, "02/02/2026");
    seb.adicionarMatricula(iury, "02/02/2026");
    lpr.adicionarMatricula(jose, "02/02/2026");

    // Testa a tentativa de matricular Iury novamente em LPR
    lpr.adicionarMatricula(iury, "02/02/2026");

    cout << "\nAlunos da turma LPR:" << endl;
    for (Aluno* aluno : lpr.listarAlunos()) {
        cout << aluno->nome << endl;
    }

    cout << "\nMatrículas de Iury:" << endl;
    for (Matricula matricula : iury.matriculas) {
        cout << matricula.turma->nome << " | " << matricula.data << endl;
    }
}
