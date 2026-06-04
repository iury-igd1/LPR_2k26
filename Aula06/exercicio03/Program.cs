/* 
Exercício 03:
    Desenvolva um programa que simule um sistema de seleção de heróis da Marvel para uma equipe. 
    O programa deve ter as seguintes funcionalidades:

    a) Cadastro de Heróis:
    Crie uma função chamada cadastrarHeroi que permita ao usuário inserir o nome, o poder e a pontuação de 
    um herói. A função deve solicitar essas informações ao usuário e armazená-las em variáveis. Não é 
    necessário armazenar os heróis em uma lista ou vetor. O programa deve permitir o cadastro de até 5 heróis.

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
    - Utilize variáveis locais para armazenar as informações dos heróis e da equipe;
    - Não utilize classes, vetores ou listas.
*/

class Program {

    static void cadastrarHeroi(ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5,
        ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5,
        ref int pts1, ref int pts2, ref int pts3, ref int pts4, ref int pts5, ref int totalHerois) {

        if (totalHerois >= 5) {
            Console.WriteLine("\nLimite de heróis cadastrados atingido.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("             CADASTRO DE HERÓI             ");
        Console.WriteLine("-------------------------------------------\n");
        Console.WriteLine($"Vagas disponíveis: {5 - totalHerois}\n");

        Console.Write("> Nome do herói: ");
        string nome = Console.ReadLine() ?? "N/A";

        Console.Write("> Poder do herói: ");
        string poder = Console.ReadLine() ?? "N/A";

        Console.Write("> Pontuação do herói: ");
        int pts = int.Parse(Console.ReadLine() ?? "0");

        switch (totalHerois) {
            case 0:
                nome1 = nome;
                poder1 = poder;
                pts1 = pts;
                break;
            case 1:
                nome2 = nome;
                poder2 = poder;
                pts2 = pts;
                break;
            case 2:
                nome3 = nome;
                poder3 = poder;
                pts3 = pts;
                break;
            case 3:
                nome4 = nome;
                poder4 = poder;
                pts4 = pts;
                break;
            case 4:
                nome5 = nome;
                poder5 = poder;
                pts5 = pts;
                break;
        }
        totalHerois++;
        Console.WriteLine($"\nHerói cadastrado com sucesso! ({totalHerois}/5)");

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    static void selecionarEquipe(string nome1, string nome2, string nome3, string nome4, string nome5,
        string poder1, string poder2, string poder3, string poder4, string poder5,
        int pts1, int pts2, int pts3, int pts4, int pts5, int totalHerois,
        ref int equipe1, ref int equipe2, ref int equipe3) {
        
        if (totalHerois < 3) {
            Console.WriteLine("\nCadastre pelo menos 3 heróis antes de montar a equipe.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("              SELEÇÃO DE EQUIPE            ");
        Console.WriteLine("-------------------------------------------\n");
        Console.WriteLine("Escolha 3 heróis para sua equipe.\n");
        
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("ID  HERÓI           PODER           PONTOS");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"1   {nome1,-15} {poder1,-15} {pts1,-6}");
        Console.WriteLine($"2   {nome2,-15} {poder2,-15} {pts2,-6}");
        Console.WriteLine($"3   {nome3,-15} {poder3,-15} {pts3,-6}");

        if (totalHerois > 3) {
            Console.WriteLine($"4   {nome4,-15} {poder4,-15} {pts4,-6}");
        }
        if (totalHerois > 4) {
            Console.WriteLine($"5   {nome5,-15} {poder5,-15} {pts5,-6}");
        }

        int temp1, temp2, temp3;

        Console.Write("\n> Escolha o primeiro herói da equipe: ");
        temp1 = int.Parse(Console.ReadLine() ?? "1");
        if (temp1 > totalHerois || temp1 < 1) {
            Console.WriteLine("\nHerói inválido.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Console.Write("> Escolha o segundo herói da equipe: ");
        temp2 = int.Parse(Console.ReadLine() ?? "2");
        if (temp2 > totalHerois || temp2 < 1) {
            Console.WriteLine("\nHerói inválido.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Console.Write("> Escolha o terceiro herói da equipe: ");
        temp3 = int.Parse(Console.ReadLine() ?? "3");
        if (temp3 > totalHerois || temp3 < 1) {
            Console.WriteLine("\nHerói inválido.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        if (temp1 == temp2 || temp1 == temp3 || temp2 == temp3) {
            Console.WriteLine("\nVocê não pode escolher o mesmo herói mais de uma vez.");
            return;
        }

        equipe1 = temp1;
        equipe2 = temp2;
        equipe3 = temp3;

        Console.WriteLine("\nEquipe cadastrada com sucesso!");

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    static int pontuacao(int heroi, int pts1, int pts2, int pts3, int pts4, int pts5)
    {
        switch (heroi) {
            case 1: 
                return pts1;
            case 2: 
                return pts2;
            case 3: 
                return pts3;
            case 4: 
                return pts4;
            case 5: 
                return pts5;
            default: 
                return 0;
        }
    }

    static void calcularPontuacaoTotal(int equipe1, int equipe2, int equipe3,
        int pts1, int pts2, int pts3, int pts4, int pts5) {

        if (equipe1 == 0 || equipe2 == 0 || equipe3 == 0) {
            Console.WriteLine("\nNenhuma equipe foi selecionada.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }
        
        int total = 0;

        total += pontuacao(equipe1, pts1, pts2, pts3, pts4, pts5);
        total += pontuacao(equipe2, pts1, pts2, pts3, pts4, pts5);
        total += pontuacao(equipe3, pts1, pts2, pts3, pts4, pts5);

        Console.WriteLine($"\nPontuação total da equipe: {total} pts");

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    static void heroi(int heroi, string nome1, string nome2, string nome3, string nome4, string nome5,
        string poder1, string poder2, string poder3, string poder4, string poder5,
        int pts1, int pts2, int pts3, int pts4, int pts5) {
        
        switch (heroi) {
            case 1:
                Console.WriteLine("[1] " + nome1);
                Console.WriteLine("    Poder: " + poder1);
                Console.WriteLine("    Pontuação: " + pts1 + " pts\n");
                break;
            case 2:
                Console.WriteLine("[2] " + nome2);
                Console.WriteLine("    Poder: " + poder2);
                Console.WriteLine("    Pontuação: " + pts2 + " pts\n");
                break;
            case 3:
                Console.WriteLine("[3] " + nome3);
                Console.WriteLine("    Poder: " + poder3);
                Console.WriteLine("    Pontuação: " + pts3 + " pts\n");
                break;
            case 4:
                Console.WriteLine("[4] " + nome4);
                Console.WriteLine("    Poder: " + poder4);
                Console.WriteLine("    Pontuação: " + pts4 + " pts\n");
                break;
            case 5:
                Console.WriteLine("[5] " + nome5);
                Console.WriteLine("    Poder: " + poder5);
                Console.WriteLine("    Pontuação: " + pts5 + " pts\n");
                break;
        }
    }
    static void exibirEquipe(int equipe1, int equipe2, int equipe3,
        string nome1, string nome2, string nome3, string nome4, string nome5,
        string poder1, string poder2, string poder3, string poder4, string poder5,
        int pts1, int pts2, int pts3, int pts4, int pts5) {
        
        if (equipe1 == 0 || equipe2 == 0 || equipe3 == 0) {
            Console.WriteLine("\nEquipe não selecionada.");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }
        
        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("            EQUIPE SELECIONADA            ");
        Console.WriteLine("-------------------------------------------\n");
        heroi(equipe1, nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pts1, pts2, pts3, pts4, pts5);
        heroi(equipe2, nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pts1, pts2, pts3, pts4, pts5);
        heroi(equipe3, nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pts1, pts2, pts3, pts4, pts5);
        Console.WriteLine("-------------------------------------------");
        calcularPontuacaoTotal(equipe1, equipe2, equipe3, pts1, pts2, pts3, pts4, pts5);
    }

    static void menuPrincipal(ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5,
        ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5,
        ref int pts1, ref int pts2, ref int pts3, ref int pts4, ref int pts5,
        ref int equipe1, ref int equipe2, ref int equipe3, ref int totalHerois) {
        
        int opcao = 0;
        
        while (opcao != 5) {
            Console.Clear();
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

            opcao = int.Parse(Console.ReadLine() ?? "5");

            switch (opcao) {
                case 1:
                    cadastrarHeroi(ref nome1, ref nome2, ref nome3, ref nome4, ref nome5,
                        ref poder1, ref poder2, ref poder3, ref poder4, ref poder5,
                        ref pts1, ref pts2, ref pts3, ref pts4, ref pts5, ref totalHerois);
                    break;
                case 2:
                    selecionarEquipe(nome1, nome2, nome3, nome4, nome5,
                        poder1, poder2, poder3, poder4, poder5,
                        pts1, pts2, pts3, pts4, pts5,
                        totalHerois, ref equipe1, ref equipe2, ref equipe3);
                    break;
                case 3:
                    calcularPontuacaoTotal(equipe1, equipe2, equipe3, pts1, pts2, pts3, pts4, pts5);
                    break;
                case 4:
                    exibirEquipe(equipe1, equipe2, equipe3,
                        nome1, nome2, nome3, nome4, nome5,
                        poder1, poder2, poder3, poder4, poder5,
                        pts1, pts2, pts3, pts4, pts5);
                    break;
                case 5:
                    Console.WriteLine("\nEncerrando programa.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void Main()
    {
        string nome1 = "N/A", nome2 = "N/A", nome3 = "N/A", nome4 = "N/A", nome5 = "N/A";
        string poder1 = "N/A", poder2 = "N/A", poder3 = "N/A", poder4 = "N/A", poder5 = "N/A";
        int pts1 = 0, pts2 = 0, pts3 = 0, pts4 = 0, pts5 = 0;
        int equipe1 = 0, equipe2 = 0, equipe3 = 0, totalHerois = 0;
        
        menuPrincipal(ref nome1, ref nome2, ref nome3, ref nome4, ref nome5,
            ref poder1, ref poder2, ref poder3, ref poder4, ref poder5,
            ref pts1, ref pts2, ref pts3, ref pts4, ref pts5,
            ref equipe1, ref equipe2, ref equipe3, ref totalHerois);
    }
}
