using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class food_arrangements
    {
        [Key]
        public booking_records booking_records { get; set; }

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
