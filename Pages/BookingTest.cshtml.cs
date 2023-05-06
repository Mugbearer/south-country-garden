using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages
{
    public class BookingTestModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public BookingTestModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public booking_records booking_records { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.booking_records == null || booking_records == null)
            {
                return Page();
            }

            _context.booking_records.Add(booking_records);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
