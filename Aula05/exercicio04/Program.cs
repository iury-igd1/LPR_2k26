using System.Diagnostics;

int numero;
int quadrado;
int soma = 0;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());
quadrado = numero * numero;

string quad = Convert.ToString(quadrado);

for (int i = 0; i < quad.Length; i++) {
    int digito = Convert.ToInt32(Convert.ToString(quad[i]));
    soma += digito;
}

Console.WriteLine($"Soma dos dígitos: {soma}");