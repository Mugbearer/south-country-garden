﻿using south_country_garden.Model;
using Microsoft.EntityFrameworkCore;


namespace south_country_garden.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<booking_records> booking_records { get; set; }
    }
}
