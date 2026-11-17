/* 
Exercício 04:
    Desenvolva o diagrama de classes de um jogo: pense em personagens, cenários, coisas utilizadas pelos 
    personagens, poderes, habilidades etc.
    O diagrama deve conter atributos, métodos, relacionamentos e cardinalidades.
    Implemente 3 classes principais do jogo (as que você escolher).
*/

using System;

class Arma {
    public string nome;
    public int dano;

    // Inicializa a arma com nome e dano
    public Arma(string nome, int dano) {
        this.nome = nome;
        this.dano = dano;
    }

    // Exibe o dano causado pela arma
    public void atacar() {
        Console.WriteLine($"{nome} causou {dano} de dano!");
    }
}

class Artefato {
    public string nome;
    public int cura;

    // Inicializa o artefato com nome e quantidade de cura
    public Artefato(string nome, int cura) {
        this.nome = nome;
        this.cura = cura;
    }

    // Exibe a ativação do artefato e retorna os pontos de vida recuperados
    public int ativar() {
        Console.WriteLine($"{nome} recuperou {cura} pontos de vida!");
        return cura;
    }
}

class Heroi {
    public string nome;
    public int vida;
    public Arma armaEquipada;
    public Artefato artefatoEquipado;

    // Inicializa o herói com 100 pontos de vida, uma arma e um artefato
    public Heroi(string nome, Arma arma, Artefato artefato) {
        this.nome = nome;
        vida = 100;
        armaEquipada = arma;
        artefatoEquipado = artefato;
    }

    // Executa o ataque utilizando a arma equipada pelo herói
    public void atacar() {
        Console.Write($"\n{nome} atacou um inimigo: ");
        armaEquipada.atacar();
    }

    // Acrescenta à vida do herói a cura retornada pelo artefato equipado
    public void usarArtefato() {
        vida += artefatoEquipado.ativar();
        Console.WriteLine($"\nVida atual = {vida}");
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("========================");
        Console.WriteLine("   MINECRAFT DUNGEONS   ");
        Console.WriteLine("========================\n");

        Console.Write("> Insira o nome do herói: ");
        string nome = Console.ReadLine() ?? "Herói";

        Arma espada = new Arma("Espada de Diamante", 25);
        Artefato totem = new Artefato("Totem da Regeneração", 20);
        Heroi heroi = new Heroi(nome, espada, totem);

        Console.WriteLine("\n------------------------");
        Console.WriteLine("     STATUS DO HERÓI    ");
        Console.WriteLine("------------------------");

        Console.WriteLine($"\nNome = {heroi.nome}");
        Console.WriteLine($"Vida = {heroi.vida}");
        Console.WriteLine($"Arma = {heroi.armaEquipada.nome}");
        Console.WriteLine($"Artefato = {heroi.artefatoEquipado.nome}");

        Console.WriteLine("\n------------------------");
        Console.WriteLine("        AVENTURA        ");
        Console.WriteLine("------------------------");

        heroi.vida = 60; // Simula o dano recebido pelo herói antes de utilizar o artefato de cura
        heroi.atacar();
        heroi.usarArtefato();
    }
}
