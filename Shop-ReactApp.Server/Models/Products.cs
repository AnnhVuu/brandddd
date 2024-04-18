using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop_ReactApp.Server.Models
{
    public class Products
    {
        [Key]
        [StringLength(10)]
        public string IdProduct { get; set; }

        [Required]
        [StringLength(10)]
        public string IdBrand { get; set; }

        [Required]
        [StringLength(250)]
        public string NameProduct { get; set; }

        [Required]
        [StringLength(250)]
        public string DescriptionProduct { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public float Price { get; set; }


        public int PromotionalPrice { get; set; }

        [Required]
        public string Image { get; set; }

       public string IDBrands { get; set; }
    }
}
