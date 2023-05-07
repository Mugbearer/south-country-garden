using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages.Admin_Controls
{
    public class EditModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public EditModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public booking_records booking_records { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.booking_records == null)
            {
                return NotFound();
            }

            var booking_records =  await _context.booking_records.FirstOrDefaultAsync(m => m.booking_id == id);
            if (booking_records == null)
            {
                return NotFound();
            }
            booking_records = booking_records;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(booking_records).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!booking_recordsExists(booking_records.booking_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool booking_recordsExists(int id)
        {
          return (_context.booking_records?.Any(e => e.booking_id == id)).GetValueOrDefault();
        }
    }
}
