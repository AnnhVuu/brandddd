using System.ComponentModel.DataAnnotations;

namespace Shop_ReactApp.Server.Models
{
    public class Brands
    {
        [Key]
        [StringLength(10)]
        public string IdBrand { get; set; }

        [StringLength(250)]
        [Required]
        public string NameBrand { get; set; }

        [Required]
        [StringLength(250)]
        public string Nation { get; set; }
       // public virtual ICollection<Products> Products { get; set; }
    }
}
