using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class terms_and_conditions
    {
        [Key]
        public int id { get; set; }

        public booking_records booking_ { get; set; }
    }
}
