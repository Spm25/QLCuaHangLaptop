using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLCuaHangLaptop.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }
        public float AmountPaid { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
