string[] entrada1 = Console.ReadLine()!.Split(' ');
string[] entrada2 = Console.ReadLine()!.Split(' ');

int.TryParse(entrada1[1], out int numero1);
float.TryParse(entrada1[2], out float valor1);
int.TryParse(entrada2[1], out int numero2);
float.TryParse(entrada2[2], out float valor2);

float valor = (numero1*valor1) + (numero2*valor2);

Console.WriteLine($"VALOR A PAGAR: R$ {valor:F2}");