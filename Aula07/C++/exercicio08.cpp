/* 
Exercício 08:
    Um cinema possui uma sala com 6 linhas e 8 colunas. Cada posição da matriz representa uma cadeira:
        0 = livre
        1 = ocupada
    Inicialmente todas as cadeiras devem estar livres. Crie um sistema com menu repetitivo:
        1 - Reservar assento
        2 - Cancelar reserva
        3 - Consultar assento
            Utilizar uma função chamada VerificarAssento(). A função deve retornar "Livre" ou "Ocupado".
        4 - Mostrar mapa da sala
        5 - Encerrar
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>
#include <vector>

using namespace std;

// Reserva o assento informado, se ele estiver livre
string ReservarAssento(int sala[6][8], int linha, int coluna) {
    if (sala[linha][coluna] == 0) {
        sala[linha][coluna] = 1;
        return "\nAssento reservado com sucesso!\n";
    }
    else {
        return "\nAssento já está ocupado.\n";
    }
}

// Cancela a reserva do assento informado, se ele estiver ocupado
string CancelarReserva(int sala[6][8], int linha, int coluna) {
    if (sala[linha][coluna] == 1) {
        sala[linha][coluna] = 0;
        return "\nReserva cancelada com sucesso!\n";
    }
    else {
        return "\nAssento já está livre.\n";
    }
}

// Retorna "Livre" ou "Ocupado" de acordo com o status do assento
string VerificarAssento(int sala[6][8], int linha, int coluna) {
    if (sala[linha][coluna] == 0) {
        return "Livre";
    }
    else {
        return "Ocupado";
    }
}

// Monta uma representação em texto do mapa de assentos da sala
string MostrarMapa(int sala[6][8]) {
    string mapa = "";
    mapa += "\n-----------------------------\n";
    mapa += "         MAPA DA SALA        \n";
    mapa += "-----------------------------\n\n";

    mapa += "    1 2 3 4 5 6 7 8\n\n";

    for (int i = 0; i < 6; i++) {
        mapa += to_string(i + 1) + "   ";
        for (int j = 0; j < 8; j++) {
            mapa += to_string(sala[i][j]) + " ";
        }
        mapa += "\n";
    }

    mapa += "-----------------------------\n";
    mapa += "0 - Livre\n";
    mapa += "1 - Ocupado\n";
    return mapa;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int sala[6][8] = {0};
    int opcao, linha, coluna;
    bool executando = true;
    string retorno;

    while (executando) { // Loop principal do menu, repete até o usuário escolher "Sair"
        system("cls");
        cout << "=========================" << endl;
        cout << "   SISTEMA DE RESERVAS   " << endl;
        cout << "=========================\n" << endl;
        cout << "1 - Reservar assento" << endl;
        cout << "2 - Cancelar reserva" << endl;
        cout << "3 - Consultar assento" << endl;
        cout << "4 - Exibir sala" << endl;
        cout << "5 - Sair" << endl;
        cout << "\n> Escolha uma opção: ";
        cin >> opcao;
        cin.ignore();
        
        switch (opcao) {
            case 1:
                cout << "\nDigite a linha (1-6) e coluna (1-8) para reservar (separados por espaço): ";
                cin >> linha >> coluna;
                cin.ignore();
                if (linha < 1 || linha > 6 || coluna < 1 || coluna > 8) {
                    cout << "\nPosição inválida.\n" << endl;
                    cout << "Pressione ENTER para continuar..." << endl;
                    cin.get();
                    break;
                }
                linha--;
                coluna--;
                retorno = ReservarAssento(sala, linha, coluna);
                cout << retorno << endl;
                cout << "Pressione ENTER para continuar..." << endl;
                cin.get();
                break;
            case 2:
                cout << "\nDigite a linha (1-6) e coluna (1-8) para cancelar reserva (separados por espaço): ";
                cin >> linha >> coluna;
                cin.ignore();
                if (linha < 1 || linha > 6 || coluna < 1 || coluna > 8) {
                    cout << "\nPosição inválida.\n" << endl;
                    cout << "Pressione ENTER para continuar..." << endl;
                    cin.get();
                    break;
                }
                linha--;
                coluna--;
                retorno = CancelarReserva(sala, linha, coluna);
                cout << retorno << endl;
                cout << "Pressione ENTER para continuar..." << endl;
                cin.get();
                break;
            case 3:
                cout << "\nDigite a linha (1-6) e coluna (1-8) para consultar (separados por espaço): ";
                cin >> linha >> coluna;
                cin.ignore();
                if (linha < 1 || linha > 6 || coluna < 1 || coluna > 8) {
                    cout << "\nPosição inválida.\n" << endl;
                    cout << "Pressione ENTER para continuar..." << endl;
                    cin.get();
                    break;
                }
                linha--;
                coluna--;
                retorno = VerificarAssento(sala, linha, coluna);
                cout << "\nO assento está: " << retorno << "\n" << endl;
                cout << "Pressione ENTER para continuar..." << endl;
                cin.get();
                break;
            case 4:
                cout << MostrarMapa(sala) << endl;
                cout << "Pressione ENTER para continuar..." << endl;
                cin.get();
                break;
            case 5:
                cout << "\nEncerrando programa." << endl;
                executando = false;
                break;
            default:
                cout << "\nOpção inválida. Tente novamente.\n" << endl;
                cout << "Pressione ENTER para continuar..." << endl;
                cin.get();
                break;
        }
    }
}
