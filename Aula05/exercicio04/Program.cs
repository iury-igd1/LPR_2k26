/* 
Exercício 04:
    Solicite ao usuário para inserir um número e calcule a soma 
    dos dígitos do quadrado desse número. 

    EXEMPLO:
        Entrada:    123
        Saída:      Soma dos dígitos: 18
*/

using System.Diagnostics;

int numero, quadrado, soma = 0;

Console.Write("Digite um número inteiro: ");
string entrada = Console.ReadLine()!;
int.TryParse(entrada, out numero);

quadrado = numero * numero;
string quad = Convert.ToString(quadrado);

for (int i = 0; i < quad.Length; i++) {
    int digito = Convert.ToInt32(Convert.ToString(quad[i]));
    soma += digito;
}

Console.WriteLine($"Soma dos dígitos: {soma}");
