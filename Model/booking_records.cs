using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class booking_records
    {
        [Key]
        public int booking_id { get; set; }

        [MaxLength(100)]
        [Required]
        public string name { get; set; }

        [Phone(ErrorMessage = "Please enter a valid contact number")]
        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string contact_number { get; set; }

        [MaxLength(200)]
        public string address { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [MaxLength(50)]
        [Required]
        public string email { get; set; }

        public string additional_message { get; set; }

        [MaxLength(255)]
        public string remarks { get; set; }

        [MaxLength(255)]
        public string payment_status { get; set; }

        [MaxLength(20)]
        public string booking_status { get; set; }

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

        [Range(1, 400)]
        public int pax_number { get; set; }

        [MaxLength(100)]
        public string event_time { get; set; }

        [MaxLength(50)]
        public string total_package { get; set; }

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

        [MaxLength(255)]
        public string beef { get; set; }

        [MaxLength(255)]
        public string seafood { get; set; }

        [MaxLength(255)]
        public string pork { get; set; }

        [MaxLength(255)]
        public string chicken { get; set; }

        [MaxLength(255)]
        public string pasta { get; set; }

        [MaxLength(255)]
        public string vegetable { get; set; }

        [MaxLength(255)]
        public string rice { get; set; }

        [MaxLength(255)]
        public string dessert { get; set; }
    }
}
