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
        public string Name { get; set; }

        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }

        public int DateTimeFrom { get; set; }
        public int DateTimeTo { get; set; }
        public int Capacity { get; set; }
        public virtual List<Flight> Flights { get; set; }

        public Reservation(int id, string name, string locationFrom, string locationTo, int dateTimeFrom, int dateTimeTo, int capacity)
        {

            Id = id;
            Name = name;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            DateTimeFrom = dateTimeFrom;
            DateTimeTo = dateTimeTo;
            Capacity = capacity;
        }
        public Reservation()
        { }









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
