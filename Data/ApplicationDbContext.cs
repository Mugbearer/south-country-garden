using south_country_garden.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;


namespace south_country_garden.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<booking_records> booking_records { get; set; }
        public DbSet<booking_status> booking_status { get; set; }
        public DbSet<event_add-ons> event_add_ons { get; set; }
        public DbSet<event_details> event_details { get; set; }
        public DbSet<event_inclusions> event_inclusions { get; set; }
        public DbSet<food_arrangements> food_arrangements { get; set; }
        public DbSet<terms_and_conditions> terms_and_conditions { get; set; }
    }
}