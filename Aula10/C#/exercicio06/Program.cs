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
    public string codigo;
    public Cliente? cliente; // A reserva permanece sem cliente até ser adicionada

    // Inicializa o código da reserva
    public Reserva(string codigo) {
        this.codigo = codigo;
    }
}

class Cliente {
    public string nome;
    public List<Reserva> reservas = new List<Reserva>();

    // Inicializa o nome do cliente
    public Cliente(string nome) {
        this.nome = nome;
    }

    public void addReserva(Reserva reserva) {
        // Impede que uma reserva já associada seja adicionada novamente
        if (reserva.cliente != null) {
            Console.WriteLine($"\nA reserva {reserva.codigo} já possui cliente.");
            return;
        }

        reserva.cliente = this; // Associa a reserva ao cliente atual e a registra em sua coleção de reservas
        reservas.Add(reserva);
    }

    // Exibe os códigos das reservas associadas a este cliente
    public void listarReservas() {
        Console.WriteLine($"Reservas de {nome}:");
        foreach (Reserva reserva in reservas) {
            Console.WriteLine($"- {reserva.codigo}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=========================");
        Console.WriteLine("   SISTEMA DE RESERVAS   ");
        Console.WriteLine("=========================\n");

        Cliente cliente = new Cliente("Iury");
        Reserva primeira = new Reserva("R001");
        Reserva segunda = new Reserva("R002");

        cliente.addReserva(primeira);
        cliente.addReserva(segunda);
        cliente.listarReservas();
        
        cliente.addReserva(primeira); // Testa a tentativa de repetir a reserva
    } 
}
