/* 
Exercício 05:
    Uma empresa deseja controlar os chamados abertos pelos funcionários. 
    Crie uma struct chamada Chamado contendo:
        Numero, Solicitante, Setor, Prioridade (1 a 3), Status e Descricao
    
    O programa deve possuir as seguintes funções:
      - cadastrarChamado(): Permite cadastrar até 10 chamados. Ao cadastrar, o status inicial deve ser: 
            Aberto
      - listarChamados(): Exibe todos os chamados cadastrados.
      - atualizarStatus(): Solicita o número do chamado e permite alterar o status para: 
            Em andamento, Resolvido, Cancelado
      - classificarPrioridade(): Recebe a prioridade e retorna: 
            1 = Baixa, 2 = Média, 3 = Alta
      - estatisticas(): Exibe Quantos chamados estão abertos; Quantos estão em andamento; Quantos foram 
        resolvidos; Quantos foram cancelados.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>
#include <algorithm>

using namespace std;

struct Chamado {
    int Numero;
    string Solicitante;
    string Setor;
    int Prioridade;
    string Status;
    string Descricao;
};

Chamado listaChamados[10];
int totalChamados = 0;

void pausar() {
    cout << "\nPressione ENTER para continuar..." << endl;
    cin.get();
}

// Converte o código numérico de prioridade (1 a 3) em texto
string classificarPrioridade(int prioridade) {
    switch (prioridade) {
        case 1: 
            return "Baixa";
        case 3: 
            return "Alta";
        default: 
            return "Média";
    }
}

// Interpreta a prioridade digitada pelo usuário (texto ou número) e retorna o código (1 a 3)
int lerPrioridade(string prioridade) {
    string p = prioridade;
    transform(p.begin(), p.end(), p.begin(), ::toupper);

    if (p == "BAIXA" || p == "1") {
        return 1;
    } 
    else if (p == "ALTA" || p == "3") {
        return 3;
    } 
    else {
        return 2;
    }
}

// Cadastra um novo chamado com status inicial "Aberto", se houver vaga disponível
void cadastrarChamado() {
    if (totalChamados >= 10) {
        cout << "\nLimite de chamados cadastrados atingido." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------" << endl;
    cout << "        NOVO CHAMADO          " << endl;
    cout << "-------------------------------\n" << endl;

    Chamado chamado;
    chamado.Numero = totalChamados + 1;

    cout << "> Solicitante: ";
    getline(cin, chamado.Solicitante);
    cout << "> Setor: ";
    getline(cin, chamado.Setor);
    cout << "> Prioridade (Baixa, Média ou Alta): ";
    string prioridadeStr;
    getline(cin, prioridadeStr);
    chamado.Prioridade = lerPrioridade(prioridadeStr);
    chamado.Status = "Aberto";
    cout << "> Descrição: ";
    getline(cin, chamado.Descricao);

    listaChamados[totalChamados] = chamado;
    totalChamados++;

    cout << "\nChamado #" << totalChamados << " cadastrado com sucesso!" << endl;
    pausar();
}

// Exibe todos os chamados cadastrados, com seus dados completos
void listarChamados() {
    cout << "\n-------------------------------------------------------------------------" << endl;
    cout << "                           CHAMADOS CADASTRADOS                          " << endl;
    cout << "-------------------------------------------------------------------------\n" << endl;

    if (totalChamados == 0) {
        cout << "Nenhum chamado cadastrado." << endl;
        pausar();
        return;
    }

    for (int i = 0; i < totalChamados; i++) {
        cout << "Chamado #" << listaChamados[i].Numero << endl;
        cout << "  Solicitante: " << listaChamados[i].Solicitante << endl;
        cout << "  Setor:       " << listaChamados[i].Setor << endl;
        cout << "  Prioridade:  " << classificarPrioridade(listaChamados[i].Prioridade) << endl;
        cout << "  Status:      " << listaChamados[i].Status << endl;
        cout << "  Descrição:   " << listaChamados[i].Descricao << "\n" << endl;
    }
    pausar();
}

// Permite alterar o status de um chamado existente
void atualizarStatus() {
    if (totalChamados == 0) {
        cout << "\nNenhum chamado cadastrado." << endl;
        pausar();
        return;
    }

    cout << "\n> Número do chamado: ";
    int numero;
    cin >> numero;
    cin.ignore();

    if (numero < 1 || numero > totalChamados) {
        cout << "\nChamado inválido." << endl;
        pausar();
        return;
    }

    cout << "\nNovo status:" << endl;
    cout << "1 - Em andamento" << endl;
    cout << "2 - Resolvido" << endl;
    cout << "3 - Cancelado" << endl;
    cout << "> Opção: ";
    int opcaoStatus;
    cin >> opcaoStatus;
    cin.ignore();

    switch (opcaoStatus) {
        case 1:
            listaChamados[numero - 1].Status = "Em andamento";
            break;
        case 2:
            listaChamados[numero - 1].Status = "Resolvido";
            break;
        case 3:
            listaChamados[numero - 1].Status = "Cancelado";
            break;
        default:
            cout << "\nOpção inválida." << endl;
            pausar();
            return;
    }
    cout << "\nStatus atualizado com sucesso!" << endl;
    pausar();
}

// Exibe quantos chamados estão em cada status (aberto, em andamento, resolvido, cancelado)
void estatisticas() {
    int abertos = 0, andamento = 0, resolvidos = 0, cancelados = 0;

    for (int i = 0; i < totalChamados; i++) {
        if (listaChamados[i].Status == "Aberto") {
            abertos++; 
        } 
        else if (listaChamados[i].Status == "Em andamento") {
            andamento++; 
        } 
        else if (listaChamados[i].Status == "Resolvido") {
            resolvidos++; 
        } 
        else if (listaChamados[i].Status == "Cancelado") {
            cancelados++; 
        }
    }

    cout << "\n-------------------------------" << endl;
    cout << "         ESTATÍSTICAS         " << endl;
    cout << "-------------------------------\n" << endl;
    cout << "Abertos:       " << abertos << endl;
    cout << "Em andamento:  " << andamento << endl;
    cout << "Resolvidos:    " << resolvidos << endl;
    cout << "Cancelados:    " << cancelados << "\n" << endl;
    pausar();
}

void menuPrincipal() {
    int opcao = 0;

    while (opcao != 5) {
        system("cls");
        cout << "===============================" << endl;
        cout << "   GERENCIAMENTO DE CHAMADOS   " << endl;
        cout << "===============================\n" << endl;
        cout << "-------------------------------" << endl;
        cout << "         MENU DE OPÇÕES        " << endl;
        cout << "-------------------------------\n" << endl;
        cout << "1 - Cadastrar novo chamado" << endl;
        cout << "2 - Exibir chamados" << endl;
        cout << "3 - Atualizar status de chamado" << endl;
        cout << "4 - Exibir estatísticas" << endl;
        cout << "5 - Sair\n" << endl;
        cout << "> Escolha uma opção: ";
        cin >> opcao;
        cin.ignore();

        switch (opcao) {
            case 1:
                cadastrarChamado();
                break;
            case 2:
                listarChamados();
                break;
            case 3:
                atualizarStatus();
                break;
            case 4:
                estatisticas();
                break;
            case 5:
                cout << "\nEncerrando programa." << endl;
                break;
            default:
                cout << "\nOpção inválida." << endl;
                pausar();
                break;
        }
    }
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
    menuPrincipal();
}