using System;
using Sistema_reserva.Entities.Exceptions;
namespace Sistema_reserva
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Numero da sala");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Checkin data");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkou data");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(num, checkin, checkout);
                Console.WriteLine($"Reserva: {reservation}");

                Console.WriteLine("");
                Console.WriteLine("Entre data para atualizar a reserva: ");
                Console.Write("Check in data (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check out data (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine($"Reserva: {reservation}");
            }
            catch(DomainEx e)
            {
                Console.WriteLine($"Erro na reserva {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Erro na entrada do numero da sala: {e.Message}");
            }
        }
    }
}
