using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages
{
    public class BookingModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public BookingModel(south_country_garden.Data.ApplicationDbContext context)
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

            SendEmail(booking_records);

            return RedirectToPage("./Index");
        }

        private static void SendEmail(booking_records data)
        {
            try
            {
                MailMessage clientMail = new MailMessage();
                SmtpClient clientOne = new SmtpClient("smtp.office365.com");
                clientMail.From = new MailAddress("kris.p.bacon2023@outlook.com", "Kris P. Bacon");
                clientMail.To.Add(data.email);

                clientMail.Subject = "Preliminary Quote";
                clientMail.IsBodyHtml = true;
                clientMail.Body = $"Greetings {data.name}!" +
                    $"<br><br>Thank you for booking South Country Garden. Please expect a response soon!";
                clientOne.EnableSsl = true;
                clientOne.Port = 587;
                clientOne.Credentials = new System.Net.NetworkCredential("kris.p.bacon2023@outlook.com", "SamplePassword123");
                clientOne.Send(clientMail);

                MailMessage scgMail = new MailMessage();
                SmtpClient clientTwo = new SmtpClient("smtp.office365.com");
                scgMail.From = new MailAddress("kris.p.bacon2023@outlook.com", "Kris P. Bacon");
                scgMail.To.Add("kris.p.bacon2023@outlook.com");

                scgMail.Subject = "New Client Booking";
                scgMail.IsBodyHtml = true;
                scgMail.Body = "Iformation on new client booking:<br><br>" +
                    $"<b>Full Name:</b> {data.name}<br><b>Contact Number:</b> {data.contact_number}<br>" +
                    $"<b>Email Address:</b> {data.email}<br>" +
                    $"<b>Address:</b> {data.address}<br><b>Additional Message:</b> {data.additional_message}";
                clientTwo.EnableSsl = true;
                clientTwo.Port = 587;
                clientTwo.Credentials = new System.Net.NetworkCredential("kris.p.bacon2023@outlook.com", "SamplePassword123");
                clientTwo.Send(scgMail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
