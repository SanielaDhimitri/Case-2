using System.ComponentModel.DataAnnotations;

namespace Case_2.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public Role Role { get; set; }

  
        public User(int userId, string name, string email, string password, Role role)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }

        public User() { }
    }
}






//////////////////////////////////DB//////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////DB///////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////DB/////////////////////////////////////////////////////////

//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Data;

//namespace Case_2.Models
//{
//    public class User
//    {


//        [Key]
//        public int UserId { get; set; }

//        [Required]
//        public string Name { get; set; } = "";

//        [Required]
//        [EmailAddress]
//        public string Email { get; set; } = "";

//        [Required]
//        public string Password { get; set; } = "";


//        [Required]
//        public int RoleId { get; set; }

//        [ForeignKey("RoleId")]
//        public Role Role { get; set; }


//        public User(int userId, string name, string email, string password, Role role)
//        {
//            UserId = userId;
//            Name = name;
//            Email = email;
//            Password = password;
//            Role = role;
//        }

//        public User()
//        {
//        }
//    }
//}