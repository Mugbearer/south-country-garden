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
using System.Net;

namespace south_country_garden.Pages.Admin_Controls
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public booking_records booking_records { get; set; }

        public audit_trail audit_trail { get; set; }

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            booking_records = _context.booking_records.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                audit_trail = new audit_trail();
                audit_trail.account_id = Convert.ToInt32(HttpContext.Session.GetString("AccountID"));
                audit_trail.booking_id = booking_records.booking_id;
                audit_trail.datetime = DateTime.Now.ToString();
                audit_trail.action = "Edit Record";

                _context.booking_records.Update(booking_records);
                _context.audit_trail.Add(audit_trail);
                await _context.SaveChangesAsync();
                TempData["success"] = "Booking updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
