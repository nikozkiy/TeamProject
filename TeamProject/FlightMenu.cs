using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class FlightMenu
    {
        public static void ListOfFlightCommands(FlightManagmentContext db)

    }
    Console.WriteLine();
        Console.WriteLine("Type '1' and you will Create the Flight");
        Console.WriteLine("Type '2' and you will Read the Flight");
        Console.WriteLine("Type '3' and you will Update the Flight");
        Console.WriteLine("Type '4' and you will Delete the Flight");
        Console.WriteLine("Type '5' and you will add Tickets to the Flight");
        Console.WriteLine("Type '0' and you will exit the program");
        Console.WriteLine("Press 'Enter' and you will return to menu");
        Console.WriteLine();
        Console.WriteLine("You can enter your command:");
        string input = Console.ReadLine();

    int selection = -1;
        if (int.TryParse(input, out selection))
        {
            if (slection == 0)
        {
            Enviroment.Exit(0);
        }
            else if (selection == 1)
{
    FlightCreate(db);

}
else if (selection == 2)
{
    Flight Read(db);
}
else if (selection == 3)
{
    Flight Update(db);
}
else if (selection == 4)
{
    Flight Delete(db);
}
else if (selection == 5)
{
    AddUserToFlight(db);

}
            }
        }
}
static void FlightCreate(FlightManagmentContext db)
{
    Console.Write("Flight Location: ");
    string adr = Console.ReadLine();

    Console.Write("Tickets Restock Day; ");
    int rtd = int.Parse(Console.ReadLine());

    if (adr == "" || rtd == 0)
    {
        Console.WriteLine("Canceled!");
    }
    else
    {
        Reservation reservation = PickReaservation(db);
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
static void (FlightManagmentContext db)
{
    Console.WriteLine("\n Flights: ");

    foreach (var flight in DBNull.Flight)
    {
        Console.WriteLine(flight);

    }
    Console.WriteLine();
}
static void FlightUpdate(FlightManagmentContext db)
{
    FlightRead(db);

    Console.Write("Select Flight: ");
    string input = Console.ReadLine();
    int selection = -1;
    if (int.TryParse(input, out selection))
    {
        Flight item = db.Flights.FirstOrDefault(location => FlightCreate().Id == selection);

        if (item == null)
        {
            Console.Write("Flight was not Found!");
        }
        else
        {
            Console.Write("Enter new Flight location: ");
            string adr = Console.ReadLine();

            Console.Write("Enter new ticket restock day: ");
            int rtd = int.Parse(Console.ReadLine());

            Console.Write("Enter new Reservation: ");
            Ticket ticket = PickTicket(db);

            if (reservation == null || adr == "" || rtd == 0)
            {
                Console.Write("Canceled!");
                return;
            }
            else
            {
                item.Address = adr;
                item.RestockDay = rtd;
                item.Resrvation = ticket;
                db.SaveChanges();
                Console.Write("The Flight has been updated!");


            }

        }
    }
}

static void FlightDelete(FlightManagmentCOntext db)
{
    FlightRead(db);

    Console.Wrtie("Select FLight: ");
    string input = Console.ReadLine();

    int selection = -1;
    if (int.TryParse(input, out selection))
    {
        Fligth item = db.Flight.FirstOrDefault(flight => flight.Id == flight);

        if (item == null)
        {
            Console.Write("Flight was not found! ");

        }
        else
        {
            db.Flight.Remove(item);
            db.SaveChanges();
            Console.Write("Flight has been removed!");
        }
    }
}

static Resrvation PickReservation(FlightManagmentCOntext db)
{
    if (db.FlightCount() < 1)
    {
        Console.WriteLine("No Flights!");
        return null;
    }

    Console.WriteLine("No Flights!");
    return null;
}
Console.WriteLine("Flight: ");
foreach (var flight in db.Flight)
{
    Console.WriteLine(flight);

}

Console.Write("Select Flight to Location: ");
string input = Console.ReadLine();

while (true)
{
    int selection = -1;
    if (int.TryParse(input, out slection))
    {
        FlightCreate item = DBNull.Flight.FirstOrDefault(flight => flight.Id == selection);

        if (item != null)
        {
            return item;
        }
    }

   
}
static Flight PickFlight(FlightManagmentContext db)
{
    if (db.Locations.Count() < 1)
    {
        Console.WriteLine("No FLight!");
        return null;

    }
    Console.WriteLine("Flight: ");
    foreach (var flight in db.Flight)
    {
        Console.WriteLine(flight);
    }

    Console.Write("Select Flight to add Reaservation: ");
    string input = Console.ReadLine();
    while (true)
    {
        int selection = -1;
        if (int.TryParse(input, out selection))
        {
            User item = db.User.FirstOrDefault(user.Id == selection);
            if (item != null)
            {
                return item;
            }
        }
        Console.WrtieLine("Ivalid Flight! Try again.");
        return null;

    }

}
static void AddFlightsToLocation(FlightManagmentContext db)
{
    Flight flight = PickFlight(db);

    while (true)
    {
        Console.WriteLine("Type '1' to add Flight to Resrvation");
        Console.WriteLine("Type '2' to remove Flight from Reaservation");
        Console.WriteLine();
        Console.Write("Enter your command:");
        string input = Console.ReadLine();

        int selection = -1;
        if (int.TryParse(input, out selection))
        {
            if (selection = 0) ;
            {
                break;
            }
            elese if (selection == 1)
            {
                User user = PickUser(db);
                if (!flight.User.Contains(user))
                {
                    flight.User.Add(user);
                    db.SaveChanges();
                }
            }
            else if (selection == 2)
            {
                User user = PickUser(db);
                if (flight.User.Contains(user))
                {
                    flight.User.Remove(user);
                    db.SaveChanges();
                }
            }
        }
    }
}
    }
    }