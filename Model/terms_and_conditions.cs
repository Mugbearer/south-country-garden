using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class terms_and_conditions
    {
        [Key]
        public booking_records booking_records { get; set; }
    }
}
