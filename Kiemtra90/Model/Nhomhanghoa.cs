using System.ComponentModel.DataAnnotations;

namespace Kiemtra90.Model
{
    public class Nhomhanghoa
    {
        [Key]
        public int NHH_ID { get; set; }
        public string NHH_Ma { get; set; }
        public string NHH_Ten { get; set; }
    }
}
