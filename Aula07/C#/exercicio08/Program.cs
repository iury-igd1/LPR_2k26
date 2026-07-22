/* 
Exercício 08:
    Um cinema possui uma sala com 6 linhas e 8 colunas. Cada posição da matriz representa uma cadeira:
        0 = livre
        1 = ocupada
    Inicialmente todas as cadeiras devem estar livres. Crie um sistema com menu repetitivo:
        1 - Reservar assento
        2 - Cancelar reserva
        3 - Consultar assento
            Utilizar uma função chamada VerificarAssento(). A função deve retornar "Livre" ou "Ocupado".
        4 - Mostrar mapa da sala
        5 - Encerrar
*/

// Reserva o assento informado, se ele estiver livre
string ReservarAssento(int[,] sala, int linha, int coluna) {
    if (sala[linha, coluna] == 0) {
        sala[linha, coluna] = 1;
        return "\nAssento reservado com sucesso!\n";
    }
    else {
        return "\nAssento já está ocupado.\n";
    }
}

// Cancela a reserva do assento informado, se ele estiver ocupado
string CancelarReserva(int[,] sala, int linha, int coluna) {
    if (sala[linha, coluna] == 1) {
        sala[linha, coluna] = 0;
        return "\nReserva cancelada com sucesso!\n";
    }
    else {
        return "\nAssento já está livre.\n";
    }
}

// Retorna "Livre" ou "Ocupado" de acordo com o status do assento
string VerificarAssento(int[,] sala, int linha, int coluna) {
    if (sala[linha, coluna] == 0) {
        return "Livre";
    }
    else {
        return "Ocupado";
    }
}

// Monta uma representação em texto do mapa de assentos da sala
string MostrarMapa(int[,] sala) {
    string mapa = "";
    mapa += "\n-----------------------------\n";
    mapa += "         MAPA DA SALA        \n";
    mapa += "-----------------------------\n\n";

    mapa += "    1 2 3 4 5 6 7 8\n\n";

    for (int i = 0; i < 6; i++) {
        mapa += (i + 1) + "   ";
        for (int j = 0; j < 8; j++) {
            mapa += sala[i, j] + " ";
        }
        mapa += "\n";
    }

    mapa += "-----------------------------\n";
    mapa += "0 - Livre\n";
    mapa += "1 - Ocupado\n";
    return mapa;
}

(int, int) LerPosicao() {
    string[] entrada = (Console.ReadLine() ?? "").Split(' ');
    int l = int.Parse(entrada[0]);
    int c = int.Parse(entrada[1]);
    return (l, c);
}

bool PosicaoValida(int linha, int coluna) {
    return linha >= 1 && linha <= 6 && coluna >= 1 && coluna <= 8;
}

int[,] sala = new int[6, 8];
bool executando = true;
string retorno;

// Loop principal do menu, repete até o usuário escolher "Sair"
while (executando) {
    Console.Clear();
    Console.WriteLine("=========================");
    Console.WriteLine("   SISTEMA DE RESERVAS   ");
    Console.WriteLine("=========================\n");
    Console.WriteLine("1 - Reservar assento");
    Console.WriteLine("2 - Cancelar reserva");
    Console.WriteLine("3 - Consultar assento");
    Console.WriteLine("4 - Exibir sala");
    Console.WriteLine("5 - Sair");
    Console.Write("\n> Escolha uma opção: ");
    int.TryParse(Console.ReadLine(), out int opcao);

    int linha, coluna;

    switch (opcao) {
        case 1:
            Console.Write("\nDigite a linha (1-6) e coluna (1-8) para reservar (separados por espaço): ");
            (linha, coluna) = LerPosicao();
            if (!PosicaoValida(linha, coluna)) {
                Console.WriteLine("\nPosição inválida.\n");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                break;
            }
            retorno = ReservarAssento(sala, linha - 1, coluna - 1);
            Console.WriteLine(retorno);
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            break;
        case 2:
            Console.Write("\nDigite a linha (1-6) e coluna (1-8) para cancelar reserva (separados por espaço): ");
            (linha, coluna) = LerPosicao();
            if (!PosicaoValida(linha, coluna)) {
                Console.WriteLine("\nPosição inválida.\n");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                break;
            }
            retorno = CancelarReserva(sala, linha - 1, coluna - 1);
            Console.WriteLine(retorno);
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            break;
        case 3:
            Console.Write("\nDigite a linha (1-6) e coluna (1-8) para consultar (separados por espaço): ");
            (linha, coluna) = LerPosicao();
            if (!PosicaoValida(linha, coluna)) {
                Console.WriteLine("\nPosição inválida.\n");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                break;
            }
            retorno = VerificarAssento(sala, linha - 1, coluna - 1);
            Console.WriteLine($"\nO assento está: {retorno}\n");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            break;
        case 4:
            Console.WriteLine(MostrarMapa(sala));
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            break;
        case 5:
            Console.WriteLine("\nEncerrando programa.");
            executando = false;
            break;
        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.\n");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            break;
    }
}
