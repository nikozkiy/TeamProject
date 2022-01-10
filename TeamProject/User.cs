using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TeamProject
{
    class User
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]

        public string Username { get; set; }
        public string Name { get; set; }


        public User(string name, string username)
        {
            Name = name;
            Username = username;
        }
        public User()
        {
        }
    }
}
