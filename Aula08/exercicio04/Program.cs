/* 
Exercício 04:
    Desenvolva um programa que simule um sistema de seleção de heróis da Marvel para uma equipe. 
    O programa deve ter as seguintes funcionalidades:

    a) Cadastro de Heróis:
    Crie uma função chamada cadastrarHeroi que permita ao usuário inserir o nome, o poder e a pontuação de 
    um herói. A função deve solicitar essas informações ao usuário e armazená-las em um struct. O programa 
    deve permitir o cadastro de até 5 heróis.

    b) Seleção de Equipe:
    Crie uma função chamada selecionarEquipe que permita ao usuário selecionar heróis para formar sua equipe. 
    A função deve exibir os heróis cadastrados e permitir que o usuário selecione quais heróis deseja incluir 
    em sua equipe. O usuário deve ser capaz de selecionar três heróis para sua equipe.

    c) Pontuação Total da Equipe:
    Crie uma função chamada calcularPontuacaoTotal que calcule a pontuação total da equipe com base nos 
    heróis selecionados. A pontuação total da equipe deve ser a soma das pontuações individuais de cada herói.

    d) Exibição da Equipe:
    Crie uma função chamada exibirEquipe que exiba os heróis selecionados para a equipe, seu poder e a 
    pontuação total da equipe.

    e) Menu:
    Crie uma função chamada menuPrincipal que exiba um menu com as opções disponíveis para o usuário 
    (cadastro de heróis, seleção de equipe, exibição da equipe e sair do programa). O usuário deve poder 
    escolher uma das opções do menu e o programa deve executar a funcionalidade correspondente.

    Requisitos Adicionais:
    - O programa deve continuar em execução até que o usuário escolha a opção de sair;
    - Utilize structs para armazenar as informações dos heróis e da equipe;
    - Não utilize classes ou listas.
*/

using System;

class Program
{
    struct Heroi
    {
    public string Nome;
    public string Poder;
    public int Pontuacao;
    }
    
    static Heroi[] herois = new Heroi[5];
    static int totalHerois = 0;
    static int[] equipe = new int[3] { 0, 0, 0 };

    static void Pausar()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    static void CadastrarHeroi()
    {
        if (totalHerois >= 5)
        {
            Console.WriteLine("\nLimite de heróis cadastrados atingido.");
            Pausar();
            return;
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("             CADASTRO DE HERÓI             ");
        Console.WriteLine("-------------------------------------------\n");

        Heroi heroi = new Heroi();

        Console.Write("> Nome do herói: ");
        heroi.Nome = Console.ReadLine() ?? "";

        Console.Write("> Poder do herói: ");
        heroi.Poder = Console.ReadLine() ?? "";

        Console.Write("> Pontuação do herói: ");
        heroi.Pontuacao = int.Parse(Console.ReadLine() ?? "0");

        herois[totalHerois] = heroi;
        totalHerois++;

        Console.WriteLine($"\nHerói cadastrado com sucesso! ({totalHerois}/5)");
        Pausar();
    }

    static void SelecionarEquipe()
    {
        if (totalHerois < 3)
        {
            Console.WriteLine("\nCadastre pelo menos 3 heróis antes de montar a equipe.");
            Pausar();
            return;
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("              SELEÇÃO DE EQUIPE            ");
        Console.WriteLine("-------------------------------------------\n");

        Console.WriteLine("ID  HERÓI           PODER           PONTOS");
        Console.WriteLine("-------------------------------------------");

        for (int i = 0; i < totalHerois; i++)
        {
            Console.WriteLine(
                $"{i + 1}   {herois[i].Nome,-15} {herois[i].Poder,-15} {herois[i].Pontuacao}"
            );
        }

        int[] escolhidos = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\n> Escolha o herói {i + 1} da equipe: ");
            int escolha = int.Parse(Console.ReadLine() ?? "0");

            if (escolha < 1 || escolha > totalHerois)
            {
                Console.WriteLine("\nHerói inválido.");
                Pausar();
                return;
            }

            bool repetido = false;

            for (int j = 0; j < i; j++)
            {
                if (escolhidos[j] == escolha)
                {
                    repetido = true;
                    break;
                }
            }

            if (repetido)
            {
                Console.WriteLine("\nVocê não pode escolher o mesmo herói mais de uma vez.");
                Pausar();
                return;
            }

            escolhidos[i] = escolha;
        }

        for (int i = 0; i < 3; i++)
        {
            equipe[i] = escolhidos[i];
        }

        Console.WriteLine("\nEquipe cadastrada com sucesso!");
        Pausar();
    }

    static int CalcularPontuacaoTotal()
    {
        int total = 0;

        for (int i = 0; i < 3; i++)
        {
            total += herois[equipe[i] - 1].Pontuacao;
        }

        return total;
    }

    static void ExibirEquipe()
    {
        if (equipe[0] == 0 || equipe[1] == 0 || equipe[2] == 0)
        {
            Console.WriteLine("\nEquipe não selecionada.");
            Pausar();
            return;
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("            EQUIPE SELECIONADA            ");
        Console.WriteLine("-------------------------------------------\n");

        for (int i = 0; i < 3; i++)
        {
            Heroi h = herois[equipe[i] - 1];

            Console.WriteLine($"[{equipe[i]}] {h.Nome}");
            Console.WriteLine($"    Poder: {h.Poder}");
            Console.WriteLine($"    Pontuação: {h.Pontuacao} pts\n");
        }

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"\nPontuação total da equipe: {CalcularPontuacaoTotal()} pts");

        Pausar();
    }

    static void MenuPrincipal()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("   SISTEMA DE FORMAÇÃO DE EQUIPES MARVEL   ");
            Console.WriteLine("===========================================\n");

            Console.WriteLine($"Heróis cadastrados: {totalHerois}/5\n");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Calcular Pontuação");
            Console.WriteLine("4 - Exibir Equipe");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------------------");

            Console.Write("> Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine() ?? "0");

            switch (opcao)
            {
                case 1:
                    CadastrarHeroi();
                    break;

                case 2:
                    SelecionarEquipe();
                    break;

                case 3:
                    if (equipe[0] == 0 || equipe[1] == 0 || equipe[2] == 0)
                        Console.WriteLine("\nNenhuma equipe foi selecionada.");
                    else
                        Console.WriteLine($"\nPontuação total da equipe: {CalcularPontuacaoTotal()} pts");

                    Pausar();
                    break;

                case 4:
                    ExibirEquipe();
                    break;

                case 5:
                    Console.WriteLine("\nEncerrando programa.");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    Pausar();
                    break;
            }
        }
    }

    static void Main()
    {
        MenuPrincipal();
    }
}