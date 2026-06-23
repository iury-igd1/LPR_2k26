/* 
Exercício 04:
    Crie uma struct chamada Piloto contendo:
        Nome, Equipe, Pontuação

    O programa deverá utilizar uma lista para armazenar os competidores.
    Implemente as seguintes funções:
      - CadastrarPiloto()
      - ExibirRanking()
      - CalcularPontuacaoMedia()
      - ExibirMelhorEquipe()
    O programa deve:
      - Cadastrar 10 pilotos;
      - Exibir um ranking em ordem decrescente de pontuação;
      - Calcular a média de pontos do campeonato;
      - Exibir quantos pilotos ficaram acima da média;
      - Determinar qual equipe possui a maior soma de pontos.
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
}