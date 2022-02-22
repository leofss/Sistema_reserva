using System;
using System.Collections.Generic;
using System.Text;
using Sistema_reserva.Entities.Exceptions;

namespace Sistema_reserva
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
           
        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkOut)
        {
            CheckIn = checkin;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Quarto {RoomNumber}, checkin {CheckIn.ToString("dd/MM/yyyy")}, chekout {CheckOut.ToString("dd/MM/yyyy")}, duração {Duration()} noites ";
        }
    }
}
