using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbus_Reservation_Form
{
    public class Passenger
    {
        //create properties for name and seat row and column.
        //Create string property that will display error messanges
        public string Name { get; set; }
        public int SeatNumber { get; set; }
        public string SeatPosition { get; set; }
        public static string ErrorMessage { get; set; }

        //create different constructor.
        //One with full passenger information.
        public Passenger(string name, string seatNumber, string seatPosition)
        {
            Name = name;
            SeatNumber = Convert.ToInt32(seatNumber);
            SeatPosition = seatPosition;
        }

        //One with just the name.
        public Passenger(string name)
        {
            Name = name;
        }

        //One blank constructor used to create blank object in order to access the properties and methods
        public Passenger() { }


        //validate passenger information for name, Number and Position
        public bool IsValidPassenger(string name, string Number, string Position)
        {
            if (name.Trim().Equals(""))
            {
                ErrorMessage = "Name is Required!";
                return false;
            }

            int validNumber;
            if (!int.TryParse(Number, out validNumber) || validNumber < 1 || validNumber > 35)
            {
                ErrorMessage = "Valid Seat Number is Required!";
                return false;
            }

            if (Position.ToUpper() != "A" && Position.ToUpper() != "B" && Position.ToUpper() != "C" &&
                Position.ToUpper() != "D" && Position.ToUpper() != "E" && Position.ToUpper() != "F")
            {
                ErrorMessage = " Valid Seat Position is Required!";
                return false;
            }

            return true;
        }




        //check if the seat is taken
        public bool IsSeatTaken(string SeatNumber, string SeatPosition)
        {
            var isTaken = Form1.passengers.Where(p => p.SeatNumber == Convert.ToInt32(SeatNumber) &&
                                                      p.SeatPosition.ToUpper() == SeatPosition.ToUpper()).Count();

            return isTaken == 0 ? false : true;
        }


        //get list of passenger names. This is used when serching for passenger by name (to be deleted).
        //Multiple passenger can have the same name
        public List<Passenger> GetPassengersByName(string name)
        {
            return Form1.passengers.Where(p => p.Name == name).ToList();
        }

        //add passenger to the list
        public void AddPassenger(Passenger passenger)
        {
            Form1.passengers.Add(passenger);
        }


        //remove passenger from the list
        public void RemovePassenger(Passenger passenger)
        {
            Form1.passengers.Remove(passenger);
        }
    }
}
