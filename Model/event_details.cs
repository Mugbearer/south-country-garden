using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class event_details
    {
        public int booking_id { get; set; }

        [MaxLength(50)]
        public string event_title { get; set; }

        [MaxLength(255)]
        public string color_motif { get; set; }

        [MaxLength(10)]
        public string event_date { get; set; }

        [MaxLength(50)]
        public string church { get; set; }

        [MaxLength(100)]
        public string venue { get; set; }

        [MaxLength(100)]
        public string time_preparation { get; set; }

        [Range(1,400)]
        [Required]
        public int pax_number { get; set; }
        public string event_time { get; set; }
    }
}
