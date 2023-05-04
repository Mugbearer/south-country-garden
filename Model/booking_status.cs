using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class booking_status
    {
        public int booking_id { get; set; }

        [MaxLength(255)]
        public string remarks { get; set; }

        [MaxLength(255)]
        public string payment_status { get; set; }

        [MaxLength(20)]
        public string status { get; set; }
    }
}
