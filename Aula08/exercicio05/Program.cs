/* Exercício 05:
    Uma empresa deseja controlar os chamados abertos pelos funcionários. 
    Crie uma struct chamada Chamado contendo:
        Numero, Solicitante, Setor, Prioridade (1 a 3), Status e Descricao
    
    O programa deve possuir as seguintes funções:
      - cadastrarChamado(): Permite cadastrar até 10 chamados. Ao cadastrar, o status inicial deve ser: 
            Aberto
      - listarChamados(): Exibe todos os chamados cadastrados.
      - atualizarStatus(): Solicita o número do chamado e permite alterar o status para: 
            Em andamento, Resolvido, Cancelado
      - classificarPrioridade(): Recebe a prioridade e retorna: 
            1 = Baixa, 2 = Média, 3 = Alta
      - estatisticas(): Exibe Quantos chamados estão abertos; Quantos estão em andamento; Quantos foram 
        resolvidos; Quantos foram cancelados.
*/

using System;

class Program
{
    struct Chamado
    {
        public int Numero;
        public string Solicitante;
        public string Setor;
        public int Prioridade;
        public string Status;
        public string Descricao;
    }

    static Chamado[] listaChamados = new Chamado[10];
    static int totalChamados = 0;

    static void Pausar()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    // Converte o código numérico de prioridade (1 a 3) em texto
    static string ClassificarPrioridade(int prioridade)
    {
        switch (prioridade) {
            case 1: 
                return "Baixa";
            case 3: 
                return "Alta";
            default: 
                return "Média";
        }
    }

    // Interpreta a prioridade digitada pelo usuário (texto ou número) e retorna o código (1 a 3)
    static int LerPrioridade(string prioridade)
    {
        string p = prioridade.ToUpper();

        if (p == "BAIXA" || p == "1") {
            return 1;
        } 
        else if (p == "ALTA" || p == "3") {
            return 3;
        } 
        else {
            return 2;
        }
    }

    // Cadastra um novo chamado com status inicial "Aberto", se houver vaga disponível
    static void CadastrarChamado()
    {
        if (totalChamados >= 10) {
            Console.WriteLine("\nLimite de chamados cadastrados atingido.");
            Pausar();
            return;
        }

        Console.WriteLine("\n-------------------------------");
        Console.WriteLine("          NOVO CHAMADO         ");
        Console.WriteLine("-------------------------------\n");

        Chamado chamado = new Chamado();
        chamado.Numero = totalChamados + 1;

        Console.Write("> Solicitante: ");
        chamado.Solicitante = Console.ReadLine() ?? "";
        Console.Write("> Setor: ");
        chamado.Setor = Console.ReadLine() ?? "";
        Console.Write("> Prioridade (Baixa, Média ou Alta): ");
        chamado.Prioridade = LerPrioridade(Console.ReadLine() ?? "");
        chamado.Status = "Aberto";
        Console.Write("> Descrição: ");
        chamado.Descricao = Console.ReadLine() ?? "";

        listaChamados[totalChamados] = chamado;
        totalChamados++;

        Console.WriteLine($"\nChamado #{totalChamados} cadastrado com sucesso!");
        Pausar();
    }

    // Exibe todos os chamados cadastrados, com seus dados completos
    static void ListarChamados()
    {
        Console.WriteLine("\n-------------------------------------------------------------------------");
        Console.WriteLine("                           CHAMADOS CADASTRADOS                          ");
        Console.WriteLine("-------------------------------------------------------------------------\n");

        if (totalChamados == 0) {
            Console.WriteLine("Nenhum chamado cadastrado.");
            Pausar();
            return;
        }

        for (int i = 0; i < totalChamados; i++) {
            Console.WriteLine($"Chamado #{listaChamados[i].Numero}");
            Console.WriteLine($"  Solicitante: {listaChamados[i].Solicitante}");
            Console.WriteLine($"  Setor:       {listaChamados[i].Setor}");
            Console.WriteLine($"  Prioridade:  {ClassificarPrioridade(listaChamados[i].Prioridade)}");
            Console.WriteLine($"  Status:      {listaChamados[i].Status}");
            Console.WriteLine($"  Descrição:   {listaChamados[i].Descricao}\n");
        }
        Pausar();
    }

    // Permite alterar o status de um chamado existente
    static void AtualizarStatus()
    {
        if (totalChamados == 0) {
            Console.WriteLine("\nNenhum chamado cadastrado.");
            Pausar();
            return;
        }

        Console.Write("\n> Número do chamado: ");
        int.TryParse(Console.ReadLine(), out int numero);

        if (numero < 1 || numero > totalChamados) {
            Console.WriteLine("\nChamado inválido.");
            Pausar();
            return;
        }

        Console.WriteLine("\nNovo status:");
        Console.WriteLine("1 - Em andamento");
        Console.WriteLine("2 - Resolvido");
        Console.WriteLine("3 - Cancelado");
        Console.Write("> Opção: ");
        int.TryParse(Console.ReadLine(), out int opcaoStatus);

        switch (opcaoStatus) {
            case 1:
                listaChamados[numero - 1].Status = "Em andamento";
                break;
            case 2:
                listaChamados[numero - 1].Status = "Resolvido";
                break;
            case 3:
                listaChamados[numero - 1].Status = "Cancelado";
                break;
            default:
                Console.WriteLine("\nOpção inválida.");
                Pausar();
                return;
        }
        Console.WriteLine("\nStatus atualizado com sucesso!");
        Pausar();
    }

    // Exibe quantos chamados estão em cada status (aberto, em andamento, resolvido, cancelado)
    static void Estatisticas()
    {
        int abertos = 0, andamento = 0, resolvidos = 0, cancelados = 0;

        for (int i = 0; i < totalChamados; i++) {
            switch (listaChamados[i].Status) {
                case "Aberto": 
                    abertos++; 
                    break;
                case "Em andamento": 
                    andamento++; 
                    break;
                case "Resolvido": 
                    resolvidos++; 
                    break;
                case "Cancelado": 
                    cancelados++; 
                    break;
            }
        }

        Console.WriteLine("\n-------------------------------");
        Console.WriteLine("         ESTATÍSTICAS         ");
        Console.WriteLine("-------------------------------\n");
        Console.WriteLine($"Abertos:       {abertos}");
        Console.WriteLine($"Em andamento:  {andamento}");
        Console.WriteLine($"Resolvidos:    {resolvidos}");
        Console.WriteLine($"Cancelados:    {cancelados}\n");
        Pausar();
    }

    static void MenuPrincipal()
    {
        int opcao = 0;
        while (opcao != 5) {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("   GERENCIAMENTO DE CHAMADOS   ");
            Console.WriteLine("===============================\n");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("         MENU DE OPÇÕES        ");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("1 - Cadastrar novo chamado");
            Console.WriteLine("2 - Exibir chamados");
            Console.WriteLine("3 - Atualizar status de chamado");
            Console.WriteLine("4 - Exibir estatísticas");
            Console.WriteLine("5 - Sair\n");
            Console.Write("> Escolha uma opção: ");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao) {
                case 1:
                    CadastrarChamado();
                    break;
                case 2:
                    ListarChamados();
                    break;
                case 3:
                    AtualizarStatus();
                    break;
                case 4:
                    Estatisticas();
                    break;
                case 5:
                    Console.WriteLine("\nEncerrando programa.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
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