/* 
Exercício 02:
    Faça um programa para ler os dados de um funcionário (nome e salário bruto). 
    A classe funcionário deve conter os seguintes métodos:
      - Mostrar os dados do funcionário (nome e salário líquido);
      - Aumentar o salário do funcionário com base em uma porcentagem dada.
    Tabela de Imposto:
      - 10% para salários de até 2000;
      - 15% para salários de até 3000;
      - 20% para salários superiores a 3000.

    EXEMPLO:
        Entrada:    Iury
                    2400
        Saída:      Nome = Iury
                    Salário líquido = R$ 2040.00
        Entrada:    s
                    10
        Saída:      Após aumento:
                    Nome = Iury                                     
                    Salário líquido = R$ 2244.00 
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

class Funcionario {
    public:
    string nome;
    double salarioBruto;

    // Inicializa o funcionário com nome e salário bruto
    Funcionario(string nome, double salarioBruto) { 
        this->nome = nome;
        this->salarioBruto = salarioBruto;
    }

    // Calcula o imposto aplicando a alíquota correspondente ao salário bruto
    double calcImposto() {
        if (salarioBruto <= 2000) {
            return salarioBruto * 0.1;
        }
        else if (salarioBruto <= 3000) {
            return salarioBruto * 0.15;
        }
        else {
          return salarioBruto * 0.2;
        }
    }

    // Exibe o nome e o salário líquido após descontar o imposto
    void dados() {
        double salarioLiquido = salarioBruto - calcImposto();

        cout << "\nNome = " << nome << endl;
        cout << "Salário líquido = R$ " << salarioLiquido << endl;
    }

    // Acrescenta ao salário bruto o percentual de aumento informado
    void aumentarSalario(double porcentagem) {
        salarioBruto += salarioBruto * porcentagem / 100;
    }

};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "================================" << endl;
    cout << "   INFORMAÇÕES DO FUNCIONÁRIO   " << endl;
    cout << "================================\n" << endl;

    string nome;
    double salario, porcentagem;
    char resposta;

    cout << "> Insira o nome do funcionário: ";
    getline(cin, nome);

    cout << "> Insira o salário bruto do funcionário: ";
    cin >> salario;

    Funcionario funcionario(nome, salario);

    cout << fixed << setprecision(2);
    funcionario.dados();

    cout << "\n> Deseja aumentar o salário do funcionário? (s/n): ";
    cin >> resposta;

    if (resposta == 's' || resposta == 'S') {
        cout << "> Insira a porcentagem de aumento: ";
        cin >> porcentagem;

        funcionario.aumentarSalario(porcentagem);
        cout << "\nApós aumento:";
        funcionario.dados();
    }
}
