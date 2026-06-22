/* 
Exercício 01:
    Defina uma struct chamada Filme contendo os seguintes campos:
        Titulo, Diretor, AnoLancamento, DuracaoMinutos

    Crie um programa que:
      - Solicite os dados de 3 filmes.
      - Armazene-os em um vetor de structs.
      - Exiba todos os filmes cadastrados.
      - Informe qual é o filme mais antigo.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>

using namespace std;

struct Filme {
    string Titulo;
    string Diretor;
    int AnoLancamento;
    int DuracaoMinutos;
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    Filme listaFilmes[3];

    cout << "========================" << endl;
    cout << "   CADASTRO DE FILMES   " << endl;
    cout << "========================\n" << endl;

    for (int i = 0; i < 3; i++) { // Lê os dados de cada um dos 3 filmes
        cout << "> Informe o título do Filme " << i+1 << ": ";
        getline(cin, listaFilmes[i].Titulo);
        cout << "> Informe o nome do diretor do Filme " << i+1 << ": ";
        getline(cin, listaFilmes[i].Diretor);
        cout << "> Informe o ano de lançamento do Filme " << i+1 << ": ";
        cin >> listaFilmes[i].AnoLancamento;
        cout << "> Informe a duração (em minutos) do Filme " << i+1 << ": ";
        cin >> listaFilmes[i].DuracaoMinutos;

        cin.ignore();
        cout << endl;
    }

    cout << "Filmes cadastrados:" << endl;
    cout << "[1] " << listaFilmes[0].Titulo << endl;
    cout << "[2] " << listaFilmes[1].Titulo << endl;
    cout << "[3] " << listaFilmes[2].Titulo << endl;
    cout << endl;

    // Compara o ano de lançamento dos 3 filmes para descobrir o mais antigo
    int a1 = listaFilmes[0].AnoLancamento;
    int a2 = listaFilmes[1].AnoLancamento;
    int a3 = listaFilmes[2].AnoLancamento;

    if (a1 <= a2 && a1 <= a3) {
        cout << "O filme mais antigo é: '" << listaFilmes[0].Titulo << "'." << endl;
    }
    else if (a2 <= a1 && a2 <= a3) {
        cout << "O filme mais antigo é: '" << listaFilmes[1].Titulo << "'." << endl;
    }
    else {
        cout << "O filme mais antigo é: '" << listaFilmes[2].Titulo << "'." << endl;
    }
}
