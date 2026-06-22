/* 
Exercício 01:
    Construa uma função que retorne o reverso de um número inteiro.

    EXEMPLO:
        Entrada:    1234
        Saída:      O inverso desse número é: 4321
*/

string InversoNumero(int numero) {
    string num = numero.ToString();
    string resultado = "";

    // Percorre a string do número de trás para frente, juntando cada dígito em uma string
    for (int i = num.Length; i >= 1; i--) {
        char digito = num[i - 1];
        resultado += digito;
    }

    return resultado;
}

Console.WriteLine("=========================");
Console.WriteLine("   INVERSOR DE NÚMEROS   ");
Console.WriteLine("=========================\n");

// Lê o número informado pelo usuário
Console.Write("> Digite um número inteiro: ");
int.TryParse(Console.ReadLine(), out int numeroUsuario);

string resultado = InversoNumero(numeroUsuario);
Console.WriteLine($"\nO inverso desse número é: {resultado}");
