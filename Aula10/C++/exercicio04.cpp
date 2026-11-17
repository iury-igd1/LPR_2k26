/* 
Exercício 04:
    Desenvolva o diagrama de classes do seu jogo favorito: pense em personagens, cenários, coisas utilizadas 
    pelos personagens, poderes, habilidades, etc…
    O diagrama deve conter atributos, métodos, relacionamentos e cardinalidades.
    Implemente 3 classes principais do jogo (as que você escolher).
*/

#include <iostream>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

class Arma {
    public:
    string nome;
    int dano;

    // Inicializa a arma com nome e dano
    Arma(string nome, int dano) {
        this->nome = nome;
        this->dano = dano;
    }

    // Exibe o dano causado pela arma
    void atacar() {
        cout << nome << " causou " << dano << " de dano!" << endl;
    }
};

class Artefato {
    public:
    string nome;
    int cura;
    
    // Inicializa o artefato com nome e quantidade de cura
    Artefato(string nome, int cura) {
        this-> nome = nome;
        this->cura = cura;
    }

    // Exibe a ativação do artefato e retorna os pontos de vida recuperados
    int ativar() {
        cout << nome << " recuperou " << cura << " pontos de vida!" << endl;
        return cura;
    }
};

class Heroi {
    public:
    string nome;
    int vida;
    Arma armaEquipada;
    Artefato artefatoEquipado;

    // Inicializa o herói com 100 pontos de vida, uma arma e um artefato
    // A lista após os dois-pontos inicializa a arma e o artefato antes do corpo do construtor
    Heroi(string nome, Arma arma, Artefato artefato) : armaEquipada(arma), artefatoEquipado(artefato) {
        this->nome = nome;
        vida = 100;
    }

    // Executa o ataque utilizando a arma equipada pelo herói
    void atacar() {
        cout << "\n" << nome << " atacou um inimigo: ";
        armaEquipada.atacar();
    }

    // Acrescenta à vida do herói a cura retornada pelo artefato equipado
    void usarArtefato() {
        vida += artefatoEquipado.ativar();
        cout << "\nVida atual = " << vida << endl;
    }
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "========================" << endl;
    cout << "   MINECRAFT DUNGEONS   " << endl;
    cout << "========================\n" << endl;

    string nome;

    cout << "> Insira o nome do herói: ";
    getline(cin, nome);

    Arma espada("Espada de Diamante", 25);
    Artefato totem("Totem da Regeneração", 20);
    Heroi heroi(nome, espada, totem);

    cout << "\n------------------------" << endl;
    cout << "     STATUS DO HERÓI    " << endl;
    cout << "------------------------" << endl;

    cout << "\nNome = " << heroi.nome << endl;
    cout << "Vida = " << heroi.vida << endl;
    cout << "Arma = " << heroi.armaEquipada.nome << endl;
    cout << "Artefato = " << heroi.artefatoEquipado.nome << endl;

    cout << "\n------------------------" << endl;
    cout << "        AVENTURA        " << endl;
    cout << "------------------------" << endl;

    heroi.vida = 60; // Simula o dano recebido pelo herói antes de utilizar o artefato de cura
    heroi.atacar();
    heroi.usarArtefato();
}
