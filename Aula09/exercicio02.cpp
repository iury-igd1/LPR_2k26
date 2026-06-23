/* 
Exercício 02:
    Construa uma lista de X nomes aleatórios. 
    A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de nomes ordenados por tamanho, começando 
    com o menor. Em cada linha, só pode ser mostrado um nome de determinado tamanho, e os demais nomes com o mesmo 
    tamanho devem ser apresentados nas linhas seguintes. Siga a ordem de digitação.

    EXEMPLO:
        Entrada:    12 sergio ana maria carlos eva joaquim jo mara laura lucas ari paulo
        Saída:      jo, ana, mara, maria, sergio, joaquim
                    eva, laura, carlos
                    ari, lucas
                    paulo
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
}