# PruebaTecnica3
Basándose en el mismo escenario del sistema de reserva de asientos para un anfiteatro, llegó el momento de plantear el “sistema de tickets” que obtendrá cada persona al reservar su asiento. Para ello tener en cuenta lo siguiente:

Crear la “plantilla” necesaria para guardar los siguientes datos por ticket: número, fila, asiento, fecha de compra, fecha de validez, precio.

Usar una “base de datos lógica” mediante alguna estructura de datos que permita almacenar un número determinado de tickets. Cargar una serie de tickets a dicha estructura.

Crear un método que recorra la estructura seleccionada y sume los precios de todos los tickets. Mostrar por pantalla el total. No es necesario usar IGU para esto.

Solicitar al usuario que ingrese un número de fila. A partir de esto, mostrar por pantalla los datos de los tickets pertenecientes a esa fila. No es necesario usar IGU para esto.

Consideraciones: No es necesaria implementación ni de IGU ni de BD. Se evaluará 100% el manejo lógico del desarrollo de la aplicación.

Extra: En caso de que se desee agregar una “plantilla” para clientes con los datos: id, dni, nombre, apellido. ¿Cómo se implementaría? ¿De qué manera se relacionaría con ticket para que el mismo posea los datos del cliente que tiene asignado? Realizar la implementación.

/*
============================================
DICCIONARIO DE DATOS – SISTEMA DE TICKETS
--------------------------------------------
Cliente:
- Id (int): Identificador único
- Dni (string): Documento del cliente
- Nombre, Apellido (string)

Ticket:
- Id, Fila, Asiento (int)
- Precio (double)
- ClienteAsignado (Cliente)

Funciones:
- MostrarTotalRecaudado()
- MostrarTicketsPorFila(fila)
- MostrarTicketsPorCliente(dni)
============================================

| **Entidad / Variable**             | **Tipo de Dato**   | **Descripción**                                                         |
| ---------------------------------- | ------------------ | ----------------------------------------------------------------------- |
| `Cliente`                          | Clase              | Representa a una persona que compra un ticket.                          |
| `Id`                               | `int`              | Identificador único del cliente.                                        |
| `Dni`                              | `string`           | Documento Nacional de Identidad del cliente.                            |
| `Nombre`                           | `string`           | Nombre del cliente.                                                     |
| `Apellido`                         | `string`           | Apellido del cliente.                                                   |
| `Ticket`                           | Clase              | Representa una entrada comprada para un evento.                         |
| `Id`                               | `int`              | Identificador único del ticket.                                         |
| `Fila`                             | `int`              | Número de fila asignada.                                                |
| `Asiento`                          | `int`              | Número de asiento asignado.                                             |
| `Precio`                           | `double`           | Precio pagado por el ticket.                                            |
| `ClienteAsignado`                  | `Cliente` (objeto) | Cliente asociado al ticket. Puede ser `null` si no está asignado.       |
| `tickets`                          | `List<Ticket>`     | Lista global que almacena todos los tickets registrados en memoria.     |
| `Mostrar()`                        | Método de `Ticket` | Muestra por consola la información completa del ticket.                 |
| `CargarTicketsDePrueba()`          | `void`             | Agrega tickets de prueba a la lista para simular una carga inicial.     |
| `MostrarTotalRecaudado()`          | `void`             | Calcula e imprime el total de dinero recaudado por la venta de tickets. |
| `MostrarTicketsPorFila(int)`       | `void`             | Muestra por consola los tickets vendidos para una fila específica.      |
| `MostrarTicketsPorCliente(string)` | `void`             | Muestra los tickets comprados por un cliente según su DNI.              |

*/
