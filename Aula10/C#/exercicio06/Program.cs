/* 
Exercício 06:
    Implemente um sistema onde uma Reserva está associada a um Cliente, e um Cliente pode ter várias Reservas.
      - Crie as classes Cliente e Reserva;
      - Um Cliente pode ter várias Reservas, mas cada Reserva pertence a apenas um Cliente;
      - Em Cliente, implemente um método para adicionar uma Reserva à lista de reservas do cliente;
      - Em Reserva, adicione um atributo para referenciar o cliente que fez a reserva;
      - Crie um método em Cliente que liste todas as reservas existentes para um determinado cliente.
*/

using System;
using System.Collections.Generic;

class Reserva {
    public string Codigo;
    public Cliente? Cliente;

    public Reserva(string codigo) {
        Codigo = codigo;
    }
}

class Cliente {
    public string Nome;
    public List<Reserva> Reservas = new List<Reserva>();

    public Cliente(string nome) {
        Nome = nome;
    }

    public void addReserva(Reserva reserva) {
        if (reserva.Cliente != null) {
            Console.WriteLine($"\nA reserva {reserva.Codigo} já possui cliente.");
            return;
        }

        reserva.Cliente = this;
        Reservas.Add(reserva);
    }

    public void listarReservas() {
        Console.WriteLine($"Reservas de {Nome}:");
        foreach (Reserva reserva in Reservas) {
            Console.WriteLine($"- {reserva.Codigo}");
        }
    }
}

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Iury");
        Reserva primeira = new Reserva("R001");
        Reserva segunda = new Reserva("R002");

        Console.Clear();
        Console.WriteLine("=========================");
        Console.WriteLine("   SISTEMA DE RESERVAS   ");
        Console.WriteLine("=========================\n");

        cliente.addReserva(primeira);
        cliente.addReserva(segunda);
        cliente.listarReservas();
        
        cliente.addReserva(primeira);
    } 
}
