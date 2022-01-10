using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TeamProject
{
    class Reservation
    {
        [Key, Required]
        public int Id { get; set; }
        
        [Required]
        public string Flight { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public virtual List<Flight> Flights{ get; set; }


        //public object Transport { get;  set; }
        //public string Stop { get; set; }

        //public Trip(string name, string price, string stop)
        //{
        //    this.Name = name;
        //    this.Price = price;
        //    this.Stops = new List<Stops>();
        //    this.Stops.Add(PickStop(db));




        //}
       



        //public override string ToString()
        //{
        //    string tripstr = $"{Id} - {Name}\n\t{Price}\n\t{Transport}\n\tStops:\n";
        //    foreach (var stops in Stops) 
        //    {
        //        tripstr += $"\t\t{stops}\n";
        //    }
        //    return tripstr;
        //}
    }
}
