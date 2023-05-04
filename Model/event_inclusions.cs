using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class event_inclusions
    {
        [Key]
        public booking_records booking_records { get; set; }

        [MaxLength(255)]
        public string event_coordination { get; set; }

        [MaxLength(255)]
        public string program_hosting { get; set; }

        [MaxLength(255)]
        public string mobile_sound_system { get; set; }

        [MaxLength(255)]
        public string lighting_system { get; set; }

        [MaxLength(255)]
        public string catering { get; set; }

        [MaxLength(255)]
        public string tiffany_chairs_and_tables { get; set; }

        [MaxLength(255)]
        public string red_carpets { get; set; }

        [MaxLength(255)]
        public string personalized_cake_layers { get; set; }

        [MaxLength(255)]
        public string photo_gallery { get; set; }

        [MaxLength(255)]
        public string table_numbers { get; set; }

        [MaxLength(255)]
        public string tarpaulin { get; set; }

        [MaxLength(255)]
        public string signature_frame { get; set; }

        [MaxLength(255)]
        public string holding_area_rooms { get; set; }

        [MaxLength(255)]
        public string lcd_and_projectors { get; set; }

        [MaxLength(255)]
        public string event_extras { get; set; }
    }
}
