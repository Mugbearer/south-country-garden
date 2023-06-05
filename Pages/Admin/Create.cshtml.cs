using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages.Admin_Controls
{
    public class CreateModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public CreateModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public booking_records booking_records { get; set; } = default!;

        public audit_trail audit_trail { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.booking_records == null || booking_records == null)
            {
                return Page();
            }

            audit_trail = new audit_trail();
            audit_trail.account_id = Convert.ToInt32(HttpContext.Session.GetString("AccountID"));
            audit_trail.booking_id = booking_records.booking_id;
            audit_trail.datetime = DateTime.Now.ToString();
            audit_trail.action = "Create Record";

            _context.booking_records.Add(booking_records);
            _context.audit_trail.Add(audit_trail);
            await _context.SaveChangesAsync();
            TempData["success"] = "Booking created successfully";
            return RedirectToPage("./Index");
        }
    }
}
