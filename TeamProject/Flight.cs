using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TeamProject
{
    class Flight
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
        public virtual List<Reservation> ReservationList { get; set; }

        public Flight(string name, string locationFrom, string locationTo)
        {
            Name = name;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
        }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }


        public Flight()
        {
        }

    }
}

