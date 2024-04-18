using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop_ReactApp.Server.Models
{
    public class DetailsBill
    {
        [Key]
        [StringLength(15)]
        public string IdDetailBill { get; set; }
        public Bills Bills { get; set; }

        public string DeliveryAddress { get; set; }
        public string Note { get; set; }
    }
}
