using System;

namespace Sistema_reserva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero da sala");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Checkin data");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Checkou data");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(num, checkin, checkout);
        }
    }
}
