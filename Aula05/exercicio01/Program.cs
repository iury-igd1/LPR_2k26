using System.Diagnostics;

double soma = 0;
string[] numeros;
double qnt = 0;

Console.Write("Digite a quantidade de números e os números: ");
numeros = Console.ReadLine()!.Split();
int contador = Convert.ToInt32(numeros[0]);

while (contador > 0) {
    double numero = Convert.ToDouble(numeros[contador]);

    if (numero % 2 == 0) {
        soma += numero;
        qnt++;
    }
    contador--;
}

Console.WriteLine($"Média dos números: {soma/qnt}");