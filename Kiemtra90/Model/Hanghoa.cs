using System.ComponentModel.DataAnnotations;

namespace Kiemtra90.Model
{
    public class Hanghoa
    {
        [Key]
        public int HH_ID { get; set; }
        public int HH_NHH_ID { get; set; }
        public string HH_MA { get; set; }
        public string HH_TEN { get; set; }
        public decimal HH_GIANHAP { get; set; }
        public decimal HH_GIABAN { get; set; }
    }
}
