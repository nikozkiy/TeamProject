using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace TeamProject
{
    static class Program
    {
        static FlightManagerContext db;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FlightManagerInterface());

            using (db = new FlightManagerContext())
            {
                while (true)
                {
                    ListOfCommands();
                }
            }
        }
        static void ListOfCommands()
        {
            Console.WriteLine("Type '1' and you will see the Reservation commands");
            Console.WriteLine("Type '2' and you will see the User commands");
            Console.WriteLine("Type '3' and you will see the Flight commands");
            Console.WriteLine("Type '0' and you will Exit the program");
            Console.WriteLine("Press 'Enter' and you will return to menu");
            Console.WriteLine();
            Console.Write("You can enter your command: ");
            string input = Console.ReadLine();

            //int selection = -1;
            //if (int.TryParse(input, out selection))
            //{
            //    if (selection == 0)
            //    {
            //        Environment.Exit(0);
            //    }
            //    else if (selection == 1)
            //    {
            //        ReservationMenu.ListOfStoreCommands(db);
            //    }
            //    else if (selection == 2)
            //    {
            //        ReservationMenu.ListOfProductCommands(db);
            //    }
            //    else if (selection == 3)
            //    {
            //       ReservationMenu.ListOfLocationCommands(db);
            //    }
            //}
        }
    }
}
