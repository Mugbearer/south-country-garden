using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using south_country_garden.Data;

namespace south_country_garden.Pages.Admin
{
    [BindProperties]
    public class LogInModel : PageModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public void OnGet()
        {
            if (HttpContext.Session.GetString(SessionVariables.LogInState) == "true")
            {
                RedirectToPage("Index");
            }
            ViewData["usernameValidate"] = "";
            ViewData["passwordValidate"] = "";
        }

        public void OnPost()
        {
            string username = Username;
            string password = Password;

            if (username == "example" && password == "example")
            {
                ViewData["usernameValidate"] = "";
                ViewData["passwordValidate"] = "";
                HttpContext.Session.SetString(SessionVariables.LogInState, "true");
            }
            else
            {
                ViewData["usernameValidate"] = "No username exists";
                ViewData["passwordValidate"] = "Invalid password";
            }
        }
    }
}
