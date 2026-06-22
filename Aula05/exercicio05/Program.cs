/* 
Exercício 05:
    Crie um programa que simula o treinamento de um Jedi. O usuário deve inserir o número de horas de 
    treinamento por dia. O programa deve calcular o total de horas de treinamento em uma semana, 
    desconsiderando sábados e domingos, e informar quantos dias, semanas e meses seriam necessários para 
    alcançar o total de 1000 horas de treinamento. 
    Considerar 1 mês = 4,5 semanas.

    EXEMPLO:
        Entrada:    8 
        Saída:      Horas treinadas por semana: 40h
                    Serão necessários 5 meses, 2 semana(s) e 3 dia(s) para alcançar 1000h de treinamento.
*/

Console.WriteLine("==================================");
Console.WriteLine("   SIMULADOR DE TREINAMENTO JEDI  ");
Console.WriteLine("==================================\n");
Console.WriteLine("Meta: 1000 horas\n");

Console.Write("> Digite o número de horas de treinamento por dia: ");
double.TryParse(Console.ReadLine(), out double horas);

if (horas <= 0) {
    Console.WriteLine("Valor de horas inválido.");
} 
else {
    double diasTotal = 1000 / horas;

    // 5 * 4.5 = 22.5 dias úteis por mês
    int meses = (int)(diasTotal / 22.5); // Armazena somente a parte inteira
    double diasRestantes = diasTotal - meses * 22.5;

    int semanas = (int)(diasRestantes / 5); // Armazena somente a parte inteira
    diasRestantes -= semanas * 5;

    int diasFinal = (int)Math.Ceiling(diasRestantes); // Arredonda para cima

    if (diasFinal == 5) {
        semanas += 1;
        diasFinal = 0;
    }

    Console.WriteLine($"\nHoras treinadas por semana: {horas * 5}h");
    Console.WriteLine($"Serão necessários {meses} meses, {semanas} semana(s) e {diasFinal} dia(s) para alcançar 1000h de treinamento.");
}
