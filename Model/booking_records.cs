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
    }
}
