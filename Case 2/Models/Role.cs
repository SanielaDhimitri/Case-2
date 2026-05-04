using System.ComponentModel.DataAnnotations;

namespace Case_2.Models
{
    public class Roler 

    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string Name { get; set; } = "";


        public List<User> Users { get; set; } = new List<User>();

        // Default constructor
        public Roler() { }

        // Constructor me parametra
        public Roler(int roleId, string name)
        {
            RoleId = roleId;
            Name = name;
        }
    }
}


//dette klasse bruges kun  i DB 