using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages.Admin_Controls
{
    public class DetailsModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public DetailsModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public booking_records booking_records { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.booking_records == null)
            {
                return NotFound();
            }

            var booking_records = await _context.booking_records.FirstOrDefaultAsync(m => m.booking_id == id);
            if (booking_records == null)
            {
                return NotFound();
            }
            else 
            {
                booking_records = booking_records;
            }
            return Page();
        }
    }
}
