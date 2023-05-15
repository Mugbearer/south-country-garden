using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using south_country_garden.Data;

namespace south_country_garden.Pages.Admin
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("LogInState") == "true")
            {
                return RedirectToPage("Index");
            }
            ViewData["usernameValidate"] = "";
            ViewData["passwordValidate"] = "";
            return Page();
        }

        public IActionResult OnPost()
        {
            Username = Request.Form["username"];
            Password = Request.Form["password"];

            if (Username != "example")
            {
                ViewData["usernameValidate"] = "No username exists";
                return new NoContentResult();
            }
            else if (Password != "example")
            {
                ViewData["passwordValidate"] = "Invalid password";
                return new NoContentResult();
            }
            else
            {
                ViewData["usernameValidate"] = "";
                ViewData["passwordValidate"] = "";
                HttpContext.Session.SetString("LogInState", "true");
                return RedirectToPage("Index");
            }
        }
    }
}
