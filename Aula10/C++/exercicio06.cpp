/* 
Exercício 06:
    Implemente um sistema onde uma Reserva está associada a um Cliente, e um Cliente pode ter várias Reservas.
      - Crie as classes Cliente e Reserva;
      - Um Cliente pode ter várias Reservas, mas cada Reserva pertence a apenas um Cliente;
      - Em Cliente, implemente um método para adicionar uma Reserva à lista de reservas do cliente;
      - Em Reserva, adicione um atributo para referenciar o cliente que fez a reserva;
      - Crie um método em Cliente que liste todas as reservas existentes para um determinado cliente.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <list>

using namespace std;

class Cliente; // Declara antecipadamente o tipo Cliente para permitir sua referência em Reserva

class Reserva {
    public:
    string codigo;
    Cliente* cliente = nullptr; // Ainda não possui cliente

    // Inicializa o código da reserva
    Reserva(string codigo) {
        this->codigo = codigo;
    }
};

class Cliente {
    public:
    string nome;
    list<Reserva*> reservas; // Armazena os endereços das reservas associadas ao cliente

    // Inicializa o nome do cliente
    Cliente(string nome) {
        this->nome = nome;
    }

    void addReserva(Reserva& reserva) {
        // Impede que uma reserva já associada seja adicionada novamente
        if (reserva.cliente != nullptr) {
            cout << "\nA reserva " << reserva.codigo << " já possui cliente." << endl;
            return;
        }

        reserva.cliente = this; // Associa a reserva ao cliente atual e a registra em sua coleção de reservas
        reservas.push_back(&reserva); // Guarda o endereço da reserva original, sem criar uma cópia dela
    }

    // Exibe os códigos das reservas associadas a este cliente
    void listarReservas() {
        cout << "Reservas de " << nome << ":" << endl;
        for (Reserva* reserva : reservas) {
            cout << "- " << reserva->codigo << endl;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "=========================" << endl;
    cout << "   SISTEMA DE RESERVAS   " << endl;
    cout << "=========================\n" << endl;

    Cliente cliente("Iury");
    Reserva primeira("R001");
    Reserva segunda("R002");

    cliente.addReserva(primeira);
    cliente.addReserva(segunda);
    cliente.listarReservas();

    cliente.addReserva(primeira); // Testa a tentativa de repetir a reserva
}
