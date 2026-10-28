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

class Program
{
    public class Cliente {
        public string Nome = "";
        public List<Reserva> Reservas = [];

        public void AdicionarReserva(Reserva reserva) {
            Reservas.Add(reserva);
            reserva.Cliente = this;
        }
        public void ListarReservas() {
            Console.WriteLine($"Reservas do cliente {Nome}:");
            foreach (var reserva in Reservas) {
                Console.WriteLine($"- Reserva ID: {reserva.Id}, Data: {reserva.Data}");
            }
        }
    }

    public class Reserva(int id, DateTime data) {
        public int Id = id;
        public DateTime Data = data;
        public Cliente? Cliente;
    }

    static void Main()
    {
    } 
}