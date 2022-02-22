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
            if (checkOut <= checkIn)
            {
                throw new DomainEx("Check out deve ser após checkin");
            }

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
            DateTime now = DateTime.Now;

            if(checkin < now || checkOut < now)
            {
                throw new DomainEx("Datas de reserva devem ser datas futuras");
            }
            if(checkOut <= checkin)
            { 
                throw new DomainEx("Check out deve ser após checkin");
            }

            CheckIn = checkin;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return $"Quarto {RoomNumber}, checkin {CheckIn.ToString("dd/MM/yyyy")}, chekout {CheckOut.ToString("dd/MM/yyyy")}, duração {Duration()} noites ";
        }
    }
}
