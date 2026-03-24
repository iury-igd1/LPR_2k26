#include <iostream>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int soma = 0;

    for (int i = 51; i <= 500; i+=3) {
        if ((i % 2 == 1)) {
            soma += i;
        }
    }

    cout << soma << endl;
}