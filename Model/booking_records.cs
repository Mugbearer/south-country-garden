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
        [MinLength(5)]
        [MaxLength(20)]
        [Required]
        public int contact_number { get; set; }

        [MaxLength(200)]
        public string address { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [MaxLength(50)]
        [Required]
        public string email { get; set; }

        public string additional_message { get; set; }

        public ICollection<booking_status> booking_statuse_s { get; set; }
        public ICollection<event_add_ons> event_add_ons_s { get; set; }
        public ICollection<event_details> event_details_s { get; set; }
        public ICollection<event_inclusions> event_inclusions_s { get; set; }
        public ICollection<food_arrangements> food_arrangements_s { get; set; }
        public ICollection<terms_and_conditions> terms_and_conditions_s { get; set; }
    }
}
