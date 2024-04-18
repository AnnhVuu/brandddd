using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop_ReactApp.Server.Models
{
    public class Bills
    {
        [Key]
        [StringLength(10)]
        public string IdBill { get; set; }

        [Required]
        [StringLength(10)]
        public string IdAccount { get; set; }

        [Required]
        public float FullPrice { get; set; }

        [Required]
        public DateTime ExportDate { get; set; }

        [Required]
        public bool DeliveryStatus { get; set; }
        public  List<DetailsBill> DetailsBill { get; set; }
    }
}
