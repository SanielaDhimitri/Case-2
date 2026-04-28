using Case_2.Models;
using Case_2.Services.UserServ;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Case_2.Pages.UsersPage.LogInPage
{
    public class LogInFormModel : PageModel
    {
        private readonly IUserService _userService;

        public LogInFormModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public string Message { get; set; }
        [BindProperty(SupportsGet = true)]
        public Role Role { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
          

            List<User> users = _userService.GetAllUsers();
            var passwordHasher = new PasswordHasher<string>();

            foreach (User user in users)
            {
                if (Email == user.Email)
                {
                    var result = passwordHasher.VerifyHashedPassword(
                        null,
                        user.Password,
                        Password
                    );

                    if (result == PasswordVerificationResult.Success)
                    {
                        if (user.Role != Role)
                        {
                            Message = "Forkert login type!";
                            return Page();
                        }

                        var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

                        var claimsIdentity = new ClaimsIdentity(
                            claims,
                            CookieAuthenticationDefaults.AuthenticationScheme
                        );

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity)
                        );

                        if (user.Role == Role.Admin)
                        {
                            return RedirectToPage("/UsersPage/LogInPage/AdminDashBoard");
                        }
                        else
                        {
                            return RedirectToPage("/UsersPage/GetAllLokaler");
                        }
                    }
                }
            }

            Message = "Invalid attempt";
            return Page();
        }
    }

}
