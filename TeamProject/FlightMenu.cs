using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class FlightMenu
    {
        public static void ListOfFlightCommands(FlightManagementContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Type '1' and you will Create the Flight");
            Console.WriteLine("Type '2' and you will Read the Flight");
            Console.WriteLine("Type '3' and you will Update the Flight");
            Console.WriteLine("Type '4' and you will Delete the Flight");
            Console.WriteLine("Type '5' and you will add Ticket to the Flight");
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
                else if (selection == 5)
                {
                    AddUserToFlight(db);
                }
            }
        }
        static void FlightCreate(FlightManagementContext db)
        {
            Console.Write("Flight Location: ");
            string adr = Console.ReadLine();

            Console.Write("Ticket Restock Day: ");
            int rtd = int.Parse(Console.ReadLine());

            if (adr == "" || rtd == 0)
            {
                Console.WriteLine("Canceled!");
            }
            else
            {
                Reservation reservation = PickReservation(db);
                if (reservation == null)
                {
                    Console.WriteLine("Canceled!");
                }
                else
                {
                    Flight flight = new Flight(adr, rtd, flight);
                    db.Flight.Add(flight);
                    db.SaveChanges();
                    Console.WriteLine("Flight has been added!");
                }
            }
        }
        static void FlightnRead(FlightManagementContext db)
        {

            Console.WriteLine("\n Flights: ");

            foreach (var loflight in db.Flight)
            {
                Console.WriteLine(flight);
            }
            Console.WriteLine();
        }

        static void FlightUpdate(FlightManagementContext db)
        {
            FlightRead(db);

            Console.Write("Select  Flight: ");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {

                Flight item = db.Flights.FirstOrDefault(location => flight.Id == selection);


                if (item == null)
                {
                    Console.Write(" Flight was not Found!");
                }

                else
                {
                    Console.Write("Enter new Flight location: ");
                    string adr = Console.ReadLine();

                    Console.Write("Enter new Ticket Restock Day: ");
                    int rtd = int.Parse(Console.ReadLine());

                    Console.Write("Enter new Reservation: ");
                    Flight flight = PickFlight(db);

                    if (reservation == null || adr == "" || rtd == 0)
                    {
                        Console.Write("Canceled!");
                        return;
                    }
                    else
                    {
                        item.Address = adr;
                        item.RestockDay = rtd;
                        item.Reservation = store;
                        db.SaveChanges();
                        Console.Write("The Flight has been updated!");
                    }
                }
            }
        }

        static void FlightnDelete(FlightManagementContext db)
        {
            FlightnRead(db);

            Console.Write("Select Flight: ");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {
                Flight item = db.Flight.FirstOrDefault(lflight => flightn.Id == flight);

                if (item == null)
                {
                    Console.Write("Flight was not Found!");
                }
                else
                {
                    db.Flights.Remove(item);
                    db.SaveChanges();
                    Console.Write("Flight has been removed!");
                }
            }
        }

        static Reservation PickReservation(FlightManagementContext db)
        {

            if (db.Flight.Count() < 1)
            {
                Console.WriteLine("No Flights!");
                return null;
            }

            Console.WriteLine("Flights:");
            foreach (var flight in db.Flights)
            {
                Console.WriteLine(flight);
            }


            Console.Write("Select Flight to Location: ");
            string input = Console.ReadLine();

            while (true)
            {
                int selection = -1;
                if (int.TryParse(input, out selection))
                {
                    Flight item = db.Flight.FirstOrDefault(flight => flight.Id == selection);

                    if (item != null)
                    {
                        return item;
                    }
                }
            }
        }
        static Flight PickFlight(FlightManagementContext db)
        {
            if (db.Locations.Count() < 1)
            {
                Console.WriteLine("No Flight!");
                return null;
            }

            Console.WriteLine("Flight: ");
            foreach (var flight in db.Flights)
            {
                Console.WriteLine(flight);

            }

            Console.Write("Select Flight to add to Reservation: ");
            string input = Console.ReadLine();

            while (true)
            {
                int selection = -1;
                if (int.TryParse(input, out selection))
                {
                    Flight item = db.Flights.FirstOrDefault(flight => flight.Id == flight);

                    if (item != null)
                    {
                        return item;
                    }
                    Console.WriteLine("Invalid Flight! Try again.");
                }
            }
        }
        static User PickUser(FlightManagementContext db)
        {
            if (db.Flights.Count() < 1)
            {
                Console.WriteLine("No Flight!");
                return null;
            }

            Console.WriteLine("Flight:");
            foreach (var product in db.Flights)
            {
                Console.WriteLine(flight);
            }
            Console.Write("Select  Flight to add to Reservation: ");
            string input = Console.ReadLine();

            while (true)
            {
                int selection = -1;
                if (int.TryParse(input, out selection))
                {
                    User item = db.Users.FirstOrDefault(user => user.Id == selection);
                    if (item != null)
                    {
                        return item;
                    }
                }

                Console.WriteLine("Invalid Flight! Try again.");
                return null;
            }
        }
        static void AddFlightsToLocation(FlightManagementContext db)
        {
            Flight flight = PickFlight(db);

            while (true)
            {
                Console.WriteLine("Type '1' to add Flight to Reservation");
                Console.WriteLine("Type '2' to remove Flight from Reservation");
                Console.WriteLine("Type '0' to return in Main menu ");
                Console.WriteLine();
                Console.Write("Enter your command: ");
                string input = Console.ReadLine();

                int selection = -1;
                if (int.TryParse(input, out selection))
                {
                    if (selection == 0)
                    {
                        break;
                    }
                    else if (selection == 1)
                    {
                        User user = PickUser(db);
                        if (!Flight.Users.Contains(user))
                        {
                            flight.Users.Add(user);
                            db.SaveChanges();
                        }
                    }
                    else if (selection == 2)
                    {
                        User user = PicUser(db);
                        if (Flight.User.Contains(user))
                        {
                            Flight.Users.Remove(user);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

    }
}