/* 
Exercício:
    Faça um programa que escreva "Hello, GitHub!".
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
     setlocale(LC_ALL, "pt_BR.UTF-8");

     cout << "Hello, GitHub!" << endl;
} 
