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
    }
}