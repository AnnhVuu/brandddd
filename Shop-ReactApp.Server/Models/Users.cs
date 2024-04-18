using System.ComponentModel.DataAnnotations;

namespace Shop_ReactApp.Server.Models
{
    public class Users
    {

        [Key]
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        [Required]
        public string FullName { get; set; }

        [StringLength(250)]
        [Required]
        public string Address { get; set; }

        [StringLength(10)]
        [Required]
        public string Phone { get; set; }

        [Required]
        public DateTime Dateofbirth { get; set; }

        [Required]
        public int GioiTinh { get; set; }


    }
}
