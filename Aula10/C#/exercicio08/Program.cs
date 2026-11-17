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

using System;
using System.Collections.Generic;

class Matricula {
    public Aluno aluno;
    public Turma turma;
    public string data;

    // Registra o aluno, a turma e a data que compõem a matrícula
    public Matricula(Aluno aluno, Turma turma, string data) {
        this.aluno = aluno;
        this.turma = turma;
        this.data = data;
    }
}

class Aluno {
    public string nome;
    public List<Matricula> matriculas = new List<Matricula>();

    // Inicializa o nome do aluno
    public Aluno(string nome) {
        this.nome = nome;
    }

    public void adicionarMatricula(Turma turma, string data) {
        // Impede que o mesmo aluno seja matriculado duas vezes na mesma turma
        foreach (Matricula matricula in matriculas) {
            if (matricula.turma == turma) {
                Console.WriteLine($"{nome} já está matriculado em {turma.nome}.");
                return;
            }
        }

        Matricula nova = new Matricula(this, turma, data);

        // Registra a associação nas coleções do aluno e da turma
        matriculas.Add(nova);
        turma.matriculas.Add(nova);
    }
}

class Turma {
    public string nome;
    public List<Matricula> matriculas = new List<Matricula>();

    // Inicializa o nome da turma
    public Turma(string nome) {
        this.nome = nome;
    }

    // Encaminha o cadastro ao aluno para reutilizar a verificação de matrícula duplicada
    public void adicionarMatricula(Aluno aluno, string data) {
        aluno.adicionarMatricula(this, data);
    }

    // Monta e retorna a lista dos alunos associados às matrículas desta turma
    public List<Aluno> listarAlunos() {
        List<Aluno> alunos = new List<Aluno>();

        foreach (Matricula matricula in matriculas) {
            alunos.Add(matricula.aluno);
        }

        return alunos;
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("===========================");
        Console.WriteLine("   SISTEMA DE MATRÍCULAS   ");
        Console.WriteLine("===========================\n");

        Aluno iury = new Aluno("Iury");
        Aluno jose = new Aluno("José");

        Turma lpr = new Turma("LPR");
        Turma seb = new Turma("SEB");

        iury.adicionarMatricula(lpr, "02/02/2026");
        seb.adicionarMatricula(iury, "02/02/2026");
        lpr.adicionarMatricula(jose, "02/02/2026");

        // Testa a tentativa de matricular Iury novamente em LPR
        lpr.adicionarMatricula(iury, "02/02/2026");

        Console.WriteLine("\nAlunos da turma LPR:");
        foreach (Aluno aluno in lpr.listarAlunos()) {
            Console.WriteLine(aluno.nome);
        }

        Console.WriteLine("\nMatrículas de Iury:");
        foreach (Matricula matricula in iury.matriculas) {
            Console.WriteLine($"{matricula.turma.nome} | {matricula.data}");
        }
    } 
}
