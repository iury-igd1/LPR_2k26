/* 
Exercício 04:
    Crie uma struct chamada Piloto contendo:
        Nome, Equipe, Pontuação
    O programa deverá utilizar uma lista para armazenar os competidores.
    Implemente as seguintes funções:
      - CadastrarPiloto()
      - ExibirRanking()
      - CalcularPontuacaoMedia()
      - ExibirMelhorEquipe()
*/

using System;
using System.Collections.Generic; // Biblioteca para listas

class Program
{
    struct Piloto
    {
        public string Nome;
        public string Equipe;
        public int Pontuacao;
    }

    static int totalCadastrados = 0; 
    static List<Piloto> pilotos = new List<Piloto>(); // Lista que armazena todos os dados

    static void Pausar()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    static void CadastrarPiloto()
    {
        if (totalCadastrados >= 10) { 
            Console.WriteLine("\nLimite máximo de 10 pilotos cadastrados atingido.");
            Pausar();
            return;
        }

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("         CADASTRO DE PILOTO         ");
        Console.WriteLine("------------------------------------\n");

        int pts;
        Piloto novoPiloto = new Piloto(); // Cria uma nova instância da struct
        totalCadastrados++;

        Console.Write($"> Informe o Nome do Piloto {totalCadastrados}: ");
        novoPiloto.Nome = Console.ReadLine() ?? "";
        Console.Write($"> Informe a Equipe do Piloto {totalCadastrados}: ");
        novoPiloto.Equipe = Console.ReadLine() ?? "";
        Console.Write($"> Informe a Pontuação do Piloto {totalCadastrados}: ");
        int.TryParse(Console.ReadLine(), out pts);
        novoPiloto.Pontuacao = pts;
        
        pilotos.Add(novoPiloto); // Adiciona o struct na lista principal
        Console.WriteLine($"\nPiloto cadastrado com sucesso! ({totalCadastrados}/10)");
        Pausar();
    }

    static void ExibirRanking()
    {
        if (pilotos.Count == 0) {
            Console.WriteLine("\nNenhum piloto cadastrado ainda.");
            Pausar();
            return;
        }
        
        List<Piloto> ranking = new List<Piloto>(pilotos); // Cria uma nova lista igual a original

        for (int i = 0; i < ranking.Count; i++) { // Ordena a lista em ordem decrescente
            for (int j = i + 1; j < ranking.Count; j++) {
                // Compara a pontuação atual com a próxima. Se a próxima for maior, inverte
                if (ranking[i].Pontuacao < ranking[j].Pontuacao) {
                    Piloto temp = ranking[i];
                    ranking[i] = ranking[j];
                    ranking[j] = temp;
                }
            }
        } 

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("       RANKING DO CAMPEONATO       ");
        Console.WriteLine("------------------------------------\n");  

        for (int i = 0; i < ranking.Count; i++) {
            // Reserva 15 espaços e alinha o texto à esquerda
            Console.WriteLine($"{i + 1}º: {ranking[i].Nome,-15} | {ranking[i].Equipe,-15} | {ranking[i].Pontuacao} pts");
        }
        Pausar();
    }

    static double CalcularPontuacaoMedia()
    {
        if (pilotos.Count == 0) { // Evita divisão por zero
            return 0;
        }

        double ptsTotal = 0;
        for (int i = 0; i < pilotos.Count; i++) { // Percorre todos os elementos da lista
            ptsTotal += pilotos[i].Pontuacao; // Soma as pontuações individuais
        }
        
        return (ptsTotal / (double)pilotos.Count);
    }

    static void ExibirEstatisticasMedia()
    {
        if (pilotos.Count == 0) {
            Console.WriteLine("\nNenhum piloto cadastrado ainda.");
            Pausar();
            return;
        }

        double media = CalcularPontuacaoMedia();
        int acimaMedia = 0;

        for (int i = 0; i < pilotos.Count; i++) { // Percorre a lista principal contando quem bateu a média
            if (pilotos[i].Pontuacao >= media) {
                acimaMedia++;
            }
        }

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("       ESTATÍSTICAS DA MÉDIA       ");
        Console.WriteLine("------------------------------------\n");
        Console.WriteLine($"Média de pontos do campeonato: {media:F2} pts");
        Console.WriteLine($"Quantidade de pilotos na média ou acima: {acimaMedia}");
        Pausar();
    }

    static void ExibirMelhorEquipe()
    {
        if (pilotos.Count == 0) {
            Console.WriteLine("\nNenhum piloto cadastrado ainda.");
            Pausar();
            return;
        }

        List<string> nomeEquipes = new List<string>();
        List<int> pontosEquipes = new List<int>();

        for (int i = 0; i < pilotos.Count; i++) {
            if (nomeEquipes.Contains(pilotos[i].Equipe)) { // Se a equipe já existir na lista
                int posicao = nomeEquipes.IndexOf(pilotos[i].Equipe); // Verifica o índice e soma a pontuação
                pontosEquipes[posicao] += pilotos[i].Pontuacao;
            }
            else { // Se a equipe não existe na lista, adiciona nas duas simultaneamente
                nomeEquipes.Add(pilotos[i].Equipe);
                pontosEquipes.Add(pilotos[i].Pontuacao);
            }
        }

        int maiorPontuacao = -1;
        string melhorEquipe = "";

        for (int i = 0; i < nomeEquipes.Count; i++) {
            if (pontosEquipes[i] > maiorPontuacao) {
                maiorPontuacao = pontosEquipes[i];
                melhorEquipe = nomeEquipes[i];
            }
        }

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine($"MELHOR EQUIPE: {melhorEquipe} | {maiorPontuacao} pts");
        Console.WriteLine("------------------------------------");
        Pausar();
    }

    static void Menu()
    {
        int opcao = 0;
        while (opcao != 5) {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE CADASTRO DE PILOTOS   ");
            Console.WriteLine("====================================\n");
            Console.WriteLine($"Pilotos cadastrados: {totalCadastrados}/10\n");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 - Cadastrar Piloto");
            Console.WriteLine("2 - Exibir Ranking do Campeonato");
            Console.WriteLine("3 - Exibir Estatísticas de Média");
            Console.WriteLine("4 - Exibir Melhor Equipe");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------------------");

            Console.Write("> Escolha uma opção: ");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao) {
                case 1:
                    CadastrarPiloto();
                    break;
                case 2:
                    ExibirRanking();
                    break;
                case 3:
                    ExibirEstatisticasMedia();
                    break;
                case 4:
                    ExibirMelhorEquipe();
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
        Menu();
    }
}
