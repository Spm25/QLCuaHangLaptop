using System.ComponentModel.DataAnnotations;

namespace QLCuaHangLaptop.Models
{
    public class LaptopCharger
    {
        [Key]
        public int ChargerID { get; set; }
        public int Wattage { get; set; }
        public string Connector { get; set; }
        public int Quantity { get; set; }
        public string Quality { get; set; }
    }
}
