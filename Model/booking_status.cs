using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class booking_status
    {
        [Key]
        public int id { get; set; }

        public booking_records booking_ { get; set; }

        [MaxLength(255)]
        public string remarks { get; set; }

        [MaxLength(255)]
        public string payment_status { get; set; }

        [MaxLength(20)]
        public string status { get; set; }
    }
}
