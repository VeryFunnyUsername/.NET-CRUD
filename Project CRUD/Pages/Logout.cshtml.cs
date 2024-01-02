using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace Project_CRUD.Pages
{
    public class LogoutModel : PageModel
    {
		    private readonly SignInManager<IdentityUser> signInManager;

		    public LogoutModel(SignInManager<IdentityUser> signInManager)
		    { 
			    this.signInManager = signInManager;
		    }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLogoutAsync()
				{
						signInManager.SignOutAsync();
						return RedirectToPage("Login");
				}
				public IActionResult OnPostDontLogoutAsync()
				{
						return RedirectToPage("Index");
		}
		}
}
