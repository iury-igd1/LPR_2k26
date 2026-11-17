/* 
Exercício 01:
    Construa uma função que retorne o reverso de um número inteiro.

    EXEMPLO:
        Entrada:    1234
        Saída:      O inverso desse número é: 4321
*/


long inversoNumero(long numero) { // Inverte a ordem dos dígitos, preservando o sinal do número
    string num = numero.ToString();
    string resultado = "";

    if (num[0] == '-') {
        resultado += "-";
        // Percorre a string do número de trás para frente, juntando cada dígito em uma string
        for (int i = num.Length; i > 1; i--) {
            char digito = num[i - 1];
            resultado += digito;
        }
    }
    else {
        // Percorre a string do número de trás para frente, juntando cada dígito em uma string
        for (int i = num.Length; i >= 1; i--) {
            char digito = num[i - 1];
            resultado += digito;
        }
    }
    
    long.TryParse(resultado, out long resultadoLong); // Converte o texto invertido para número, eliminando zeros à esquerda
    return resultadoLong;
}

Console.Clear();
Console.WriteLine("=========================");
Console.WriteLine("   INVERSOR DE NÚMEROS   ");
Console.WriteLine("=========================\n");

// Lê o número informado pelo usuário
Console.Write("> Digite um número inteiro: ");
long.TryParse(Console.ReadLine(), out long numeroUsuario);

long resultado = inversoNumero(numeroUsuario);
Console.WriteLine($"\nO inverso desse número é: {resultado}");
