/* 
Exercício 04:
    Solicite ao usuário para inserir um número e calcule a soma dos dígitos do quadrado desse número. 

    EXEMPLO:
        Entrada:    4
        Saída:      Soma dos dígitos = 7
*/

int quadrado, soma = 0;

Console.WriteLine("==================================");
Console.WriteLine("   SOMA DOS DÍGITOS DO QUADRADO   ");
Console.WriteLine("==================================\n");

Console.Write("> Digite um número inteiro: ");
string entrada = Console.ReadLine()!;
int.TryParse(entrada, out int numero);

quadrado = numero * numero;
string quad = Convert.ToString(quadrado);

for (int i = 0; i < quad.Length; i++) {
    int digito = int.Parse(Convert.ToString(quad[i]));
    soma += digito;
}

Console.WriteLine($"\nSoma dos dígitos = {soma}");
