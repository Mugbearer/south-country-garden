using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class event_add_ons
    {
        [Key]
        public int id { get; set; }

        public booking_records booking_ { get; set; }

        [MaxLength(255)]
        public string hair_and_make_up { get; set; }

        [MaxLength(255)]
        public string giveaway { get; set; }

        [MaxLength(255)]
        public string photo_and_video_coverage { get; set; }

        [MaxLength(255)]
        public string photo_booth { get; set; }

        [MaxLength(255)]
        public string bridal_car { get; set; }

        [MaxLength(255)]
        public string entourage_church_flower { get; set; }

        [MaxLength(255)]
        public string additional_stages { get; set; }
    }
}
