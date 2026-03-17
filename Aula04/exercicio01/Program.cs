using System.Diagnostics;

int num;

Console.Write("Digite um número inteiro: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("PAR");
} else {
    Console.WriteLine("ÍMPAR");
}