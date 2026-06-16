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
#include <string>
#include <vector>

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
int opcao;
bool rodando = true;
string prioridade;

int classificarPrioridade(string prioridade) {
      if (prioridade == "baixa" || prioridade == "Baixa" || prioridade == "BAIXA" || prioridade == "1") {
            return 1;
      }
      else if (prioridade == "alta" || prioridade == "Alta" || prioridade == "ALTA" || prioridade == "3") {
            return 3;
      } 
      else {
            return 2;
      }
}

void cadastrarChamado() {
      listaChamados[totalChamados].Numero = totalChamados + 1;
      cout << "> Solicitante: ";
      getline(cin, listaChamados[totalChamados].Solicitante);
      cout << "> Setor: ";
      getline(cin, listaChamados[totalChamados].Setor);
      cout << "> Prioridade (Baixa, Média ou Alta): ";
      cin >> prioridade;
      listaChamados[totalChamados].Prioridade = classificarPrioridade(prioridade);
      listaChamados[totalChamados].Status = "Aberto";
      cout << "> Descrição: ";
      getline(cin, listaChamados[totalChamados].Descricao);
      totalChamados++;
      cout << endl << "Chamado cadastrado com sucesso!" << endl;
      cout << "Pressione ENTER para continuar...";
      cin >> prioridade;
}

void listarChamados() {

}

void atualizarStatus() {

}

void estatisticas() {

}

int main()
{
      setlocale(LC_ALL, "pt_BR.UTF-8");

      cout << "===============================" << endl;
      cout << "   GERENCIAMENTO DE CHAMADOS   " << endl;
      cout << "===============================\n" << endl;

      while (rodando) {
            cout << "-------------------------------" << endl;
            cout << "         MENU DE OPÇÕES        " << endl;
            cout << "-------------------------------\n" << endl;
            cout << "1 - Cadastrar novo chamado" << endl;
            cout << "2 - Exibir chamados" << endl;
            cout << "3 - Atualizar status de chamado" << endl;
            cout << "4 - Exibir estatísticas" << endl;
            cout << "5 - Sair\n" << endl;
            cout << "> Escolha uma opção: ";
            getline(cin, opcao);

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
                        cout << "Encerrando programa." << endl;
                        rodando = false;
                        break;
                  default:
                        cout << "Opção inválida.\n" << endl;
                        break;
            }
      }
}