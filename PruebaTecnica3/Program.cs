using System;
using System.Collections.Generic;
using System.Linq;
using PruebaTecnica3;

class Program
{
    static List<Ticket> tickets = new List<Ticket>();

    static void Main()
    {
        CargarTicketsDePrueba();

        Console.WriteLine("=== Sistema de Tickets ===\n");

        MostrarTotalRecaudado();

        Console.Write("\nIngrese una fila para buscar los tickets: ");
        int fila = int.Parse(Console.ReadLine());
        MostrarTicketsPorFila(fila);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void CargarTicketsDePrueba()
    {
        var cliente1 = new Cliente { Id = 1, Dni = "12345678", Nombre = "Juan", Apellido = "Pérez" };
        var cliente2 = new Cliente { Id = 2, Dni = "87654321", Nombre = "Ana", Apellido = "López" };
        var cliente3 = new Cliente { Id = 3, Dni = "11223344", Nombre = "Carlos", Apellido = "Gómez" };
        var cliente4 = new Cliente { Id = 4, Dni = "44332211", Nombre = "María", Apellido = "Fernández" };
        var cliente5 = new Cliente { Id = 5, Dni = "55667788", Nombre = "Luis", Apellido = "Martínez" };

        tickets.Add(new Ticket { Numero = 1, Fila = 1, Asiento = 1, FechaCompra = DateTime.Now, FechaValidez = DateTime.Now.AddDays(7), Precio = 1200, ClienteAsignado = cliente1 });
        tickets.Add(new Ticket { Numero = 2, Fila = 1, Asiento = 2, FechaCompra = DateTime.Now, FechaValidez = DateTime.Now.AddDays(7), Precio = 1200, ClienteAsignado = cliente2 });
        tickets.Add(new Ticket { Numero = 3, Fila = 2, Asiento = 1, FechaCompra = DateTime.Now, FechaValidez = DateTime.Now.AddDays(7), Precio = 1500, ClienteAsignado = cliente3 });
        tickets.Add(new Ticket { Numero = 4, Fila = 3, Asiento = 4, FechaCompra = DateTime.Now, FechaValidez = DateTime.Now.AddDays(7), Precio = 1500, ClienteAsignado = cliente4 });
        tickets.Add(new Ticket { Numero = 5, Fila = 3, Asiento = 5, FechaCompra = DateTime.Now, FechaValidez = DateTime.Now.AddDays(7), Precio = 1500, ClienteAsignado = cliente5 });
    }

    static void MostrarTotalRecaudado()
    {
        decimal total = tickets.Sum(t => t.Precio);
        Console.WriteLine($"Total recaudado por tickets: ${total}");
    }

    static void MostrarTicketsPorFila(int fila)
    {
        var encontrados = tickets.Where(t => t.Fila == fila).ToList();

        if (encontrados.Count == 0)
        {
            Console.WriteLine($"No se encontraron tickets en la fila {fila}.");
        }
        else
        {
            Console.WriteLine($"\nTickets en la fila {fila}:");
            foreach (var ticket in encontrados)
            {
                ticket.Mostrar();
            }
        }
    }
}



