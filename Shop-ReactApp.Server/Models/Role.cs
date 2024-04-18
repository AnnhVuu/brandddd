using System.ComponentModel.DataAnnotations;

namespace Shop_ReactApp.Server.Models
{
    public class Role
    {

        [Key]
        public int IdRole { get; set; }

        [Required]
        [StringLength(20)]
        public string RoleName { get; set; }

        public List<Accounts> Accounts { get; set; }
    }
}
