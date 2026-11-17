/* 
Exercício 07:
    Crie as classes Livro, com os atributos Titulo, Autor e AnoPublicacao, e Biblioteca, com uma lista de objetos 
    da classe Livro. Use métodos construtores, getters e setters quando necessário.
    Na classe Biblioteca, crie os métodos AdicionarLivro e ListarLivros.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <list>

using namespace std;

class Livro {
    private:
    string titulo;
    string autor;
    int anoPublicacao;

    public:
    // Inicializa o livro com título, autor e ano de publicação
    Livro(string titulo, string autor, int anoPublicacao) {
        this->titulo = titulo;
        this->autor = autor;
        this->anoPublicacao = anoPublicacao;
    }

    // Os métodos get consultam os atributos privados. Os métodos set alteram seus valores
    string getTitulo() {
        return titulo;
    }

    void setTitulo(string titulo) {
        this->titulo = titulo;
    }

    string getAutor() {
        return autor;
    }

    void setAutor(string autor) {
        this->autor = autor;
    }

    int getAnoPublicacao() {
        return anoPublicacao;
    }

    void setAnoPublicacao(int anoPublicacao) {
        this->anoPublicacao = anoPublicacao;
    }
};

class Biblioteca {
    public:
    list<Livro> livros;

    // Adiciona o livro à coleção da biblioteca
    void adicionarLivro(Livro livro) {
        livros.push_back(livro);
    }

    // Percorre a coleção e exibe os dados de cada livro cadastrado
    void listarLivros() {
        for (Livro livro : livros) {
            cout << livro.getTitulo() << " | " << livro.getAutor() << " | " << livro.getAnoPublicacao() << endl;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "===========================" << endl;
    cout << "   SISTEMA DE BIBLIOTECA   " << endl;
    cout << "===========================\n" << endl;

    Biblioteca biblioteca;

    Livro primeiro("Diário de um Banana", "Jeff Kinney", 2007);
    Livro segundo("Turma da Mônica - Nº 1", "Maurício de Sousa", 1959);

    biblioteca.adicionarLivro(primeiro);
    biblioteca.adicionarLivro(segundo);
    biblioteca.listarLivros();
}
