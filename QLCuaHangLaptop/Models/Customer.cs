using System.ComponentModel.DataAnnotations;

namespace QLCuaHangLaptop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public float TotalUnpaid { get; set; }
        public string Address { get; set; }
    }
}
