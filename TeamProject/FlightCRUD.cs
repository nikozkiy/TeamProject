using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class FlightCRUD
    {
        public static void ListOfFlightCommands(FlightManagementContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Type '1' and you will Create a Flight");
            Console.WriteLine("Type '2' and you will Read a Flight");
            Console.WriteLine("Type '3' and you will Update a Flight");
            Console.WriteLine("Type '4' and you will Delete a Flight");
            Console.WriteLine("Type '0' and you will Exit the program");
            Console.WriteLine("Press 'Enter' and you will return to menu");
            Console.WriteLine();
            Console.Write("You can enter your command: ");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {
                if (selection == 0)
                {
                    Environment.Exit(0);
                }
                else if (selection == 1)
                {
                    FlightCreate(db);
                }
                else if (selection == 2)
                {
                    FlightRead(db);
                }
                else if (selection == 3)
                {
                    FlightUpdate(db);
                }
                else if (selection == 4)
                {
                    FlightDelete(db);
                }
            }
        }

        static void ReservationCreate(FlightManagementContext db)
        {
            Console.Write("Flight Name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Canceled!");
            }
            else
            {
                Reservation reservation = new Reservation(name);
                db.Reservations.Add(reservation);
                db.SaveChanges();
                Console.WriteLine("Reservation has been added!");
            }

        }
        static void ReservationeRead(FlightManagementContext db)
        {
            Console.WriteLine("Reservation: ");
            foreach (var Reservation in db.Reservations)
            {
                Console.WriteLine(reservation);
            }
        }
        static void ReservationUpdate(FlightManagementContext db)
        {
            ReservationRead(db);
            Console.Write("Select a Reservation: ");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {
                Reservation item = db.Reservations.FirstOrDefault(reservation => reservation.Id == selection);

                if (item != null)
                {
                    Console.Write("Enter new Reservation name: ");
                    string name = Console.ReadLine();

                    item.Name = name;
                    db.SaveChanges();
                    Console.Write("The Reservation has been updated!");
                }
                else
                {
                    Console.Write("The Reservation was not found!");
                }
            }
        }

        static void ReservationDelete(FlightManagementContext db)
        {
            ReservationRead(db);

            Console.WriteLine("Select a Reservation:");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {
                Reservation item = db.Reservations.FirstOrDefault(reservatione => reservation.Id == selection);

                if (item != null)
                {
                    db.Reservations.Remove(item);
                    db.SaveChanges();
                    Console.WriteLine("The Reservation has been removed!");
                }
                else
                {
                    Console.WriteLine("The Reservation was not found!");
                }
            }
        }

    }
}