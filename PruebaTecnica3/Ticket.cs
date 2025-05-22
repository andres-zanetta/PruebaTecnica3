using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica3
{

    public class Ticket
    {
        public int Numero { get; set; }
        public int Fila { get; set; }
        public int Asiento { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaValidez { get; set; }
        public decimal Precio { get; set; }
        public Cliente ClienteAsignado { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Ticket #{Numero} - Fila: {Fila}, Asiento: {Asiento}, Precio: ${Precio}");
            Console.WriteLine($"Fecha de Compra: {FechaCompra.ToShortDateString()} | Validez: {FechaValidez.ToShortDateString()}");
            if (ClienteAsignado != null)
            {
                Console.WriteLine($"Cliente: {ClienteAsignado.Nombre} {ClienteAsignado.Apellido} - DNI: {ClienteAsignado.Dni}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }

}
