#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int A, B;

    cout << "Digite dois numeros inteiros (separados por espaço): ";

    cin >> A >> B;

    if (A % B == 0 || B % A == 0) {
        cout << "Sao Multiplos" << endl;
    } else {
        cout << "Nao sao Multiplos" << endl;
    }
}