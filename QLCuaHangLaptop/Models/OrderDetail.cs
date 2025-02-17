using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLCuaHangLaptop.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public string WarrantyPeriod { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
