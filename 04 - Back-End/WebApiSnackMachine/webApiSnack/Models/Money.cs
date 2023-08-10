using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApiSnack.Models
{
    [Table("Money")]
    public class Money
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDMoney { get; set; }
        public int FiveEuro { get; set; }
        public int OneCent { get; set; }

        public int OneEuro { get; set; }

        public int QuarterCent { get; set; }

        public int TenCent { get; set; }

        public int TwentyCent { get; set; }



    }
}
