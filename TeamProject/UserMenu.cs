using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class UserMenu
    {
        public static void ListOfUserCommands(FlightManagerContext db)
        {
            Console.WriteLine();
            Console.WriteLine("Type '1' and you will Create a User");
            Console.WriteLine("Type '2' and you will Read a User");
            Console.WriteLine("Type '3' and you will Update a User");
            Console.WriteLine("Type '4' and you will Delete a User");
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
                    UserCreate(db);
                }
                else if (selection == 2)
                {
                    UserRead(db);
                }
                else if (selection == 3)
                {
                    UserUpdate(db);
                }
                else if (selection == 4)
                {
                    UserDelete(db);
                }
            }
        }

        static void UserCreate(FlightManagerContext db)
        {
            Console.Write("User Name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Canceled!");
            }
            else
            {
                User user = new User();
                db.Users.Add(user);
                db.SaveChanges();
                Console.WriteLine("User has been added!");
            }

        }
        static void UserRead(FlightManagerContext db)
        {
            Console.WriteLine("User: ");
            foreach (var user in db.Users)
            {
                Console.WriteLine(user);
            }
        }
        static void UserUpdate(FlightManagerContext db)
        {
            UserRead(db);
            Console.Write("Select a User: ");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {
                User item = db.Users.FirstOrDefault(user => user.Id == selection);

                if (item != null)
                {
                    Console.Write("Enter new Username: ");
                    string name = Console.ReadLine();

                    item.Name = name;
                    db.SaveChanges();
                    Console.Write("The User has been updated!");
                }
                else
                {
                    Console.Write("The User was not found!");
                }
            }
        }

        static void UserDelete(FlightManagerContext db)
        {
            UserRead(db);

            Console.WriteLine("Select a User:");
            string input = Console.ReadLine();

            int selection = -1;
            if (int.TryParse(input, out selection))
            {
                User item = db.Users.FirstOrDefault(user => user.Id == selection);

                if (item != null)
                {
                    db.Users.Remove(item);
                    db.SaveChanges();
                    Console.WriteLine("The User has been removed!");
                }
                else
                {
                    Console.WriteLine("The User was not found!");
                }
            }
        }
    }
}

