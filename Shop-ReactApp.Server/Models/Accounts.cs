using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Shop_ReactApp.Server.Models
{
    public class Accounts
    {
        [Key]
        [StringLength(10)]
        public string IdAccount { get; set; }

        [StringLength(250)]
        public string Email { get; set; }
        //[Required]
        //public int IdRole { get; set; }

        [StringLength(250)]
        public string Password { get; set; }


        public  Users Users { get; set; }

  
     
    }
}
