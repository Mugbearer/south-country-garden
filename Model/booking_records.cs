using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class booking_records
    {
        [Key]
        public int booking_id { get; set; }

        [Required]
        public string name { get; set; }

        [Phone(ErrorMessage = "Please enter a valid contact number")]
        [Required]
        public int contact_number { get; set; }

        public string address { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Required]
        public string email { get; set; }

        public string event_title { get; set; }

        public string color_motif { get; set; }

        public string event_date { get; set; }

        public string church { get; set; }

        public string venue { get; set; }

        public string time_preparation { get; set; }

        [Range(1, 400, ErrorMessage = "Please enter 1-300")]
        public string pax_number { get; set; }

        public string additional_message { get; set; }
    }
}
