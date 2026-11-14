/* 
Exercício 04:
    Desenvolva o diagrama de classes de um jogo: pense em personagens, cenários, coisas utilizadas pelos 
    personagens, poderes, habilidades etc.
    O diagrama deve conter atributos, métodos, relacionamentos e cardinalidades.
    Implemente 3 classes principais do jogo (as que você escolher).
*/

using System;

class Arma {
    public string Nome;
    public int Dano;

    public Arma(string nome, int dano) {
        Nome = nome;
        Dano = dano;
    }

    public void atacar() {
        Console.WriteLine($"{Nome} causou {Dano} de dano!");
    }
}

class Artefato {
    public string Nome;
    public int Cura;

    public Artefato(string nome, int cura) {
        Nome = nome;
        Cura = cura;
    }

    public int ativar() {
        Console.WriteLine($"{Nome} recuperou {Cura} pontos de vida!");
        return Cura;
    }
}

class Heroi {
    public string Nome;
    public int Vida;
    public Arma ArmaEquipada;
    public Artefato ArtefatoEquipado;

    public Heroi(string nome, Arma arma, Artefato artefato) {
        Nome = nome;
        Vida = 100;
        ArmaEquipada = arma;
        ArtefatoEquipado = artefato;
    }

    public void atacar() {
        Console.Write($"\n{Nome} atacou um inimigo: ");
        ArmaEquipada.atacar();
    }

    public void usarArtefato() {
        Vida += ArtefatoEquipado.ativar();
        Console.WriteLine($"\nVida atual: {Vida}");
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

        Console.WriteLine("\n========================");
        Console.WriteLine("     STATUS DO HERÓI    ");
        Console.WriteLine("========================\n");

        Console.WriteLine($"Nome: {heroi.Nome}");
        Console.WriteLine($"Vida: {heroi.Vida}");
        Console.WriteLine($"Arma: {heroi.ArmaEquipada.Nome}");
        Console.WriteLine($"Artefato: {heroi.ArtefatoEquipado.Nome}");

        Console.WriteLine("\n========================");
        Console.WriteLine("        AVENTURA        ");
        Console.WriteLine("========================");

        heroi.Vida = 60;
        heroi.atacar();
        heroi.usarArtefato();
    }
}
