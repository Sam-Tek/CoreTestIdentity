using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreTestIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CoreTestIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            //IdentityRole role = new IdentityRole();
            //role.Name = "Admin";
            //await _roleManager.CreateAsync(role);

            //var user = await _userManager.GetUserAsync(HttpContext.User);

            //var userx = new ApplicationUser();
            //userx.UserName = "default";
            //userx.Email = "default@default.com";
            //user.CustomTag = "gg";
            //string userPWD = "somepassword";

            //IdentityResult chkUser = await _userManager.CreateAsync(userx, userPWD);

            ////Add default User to Role Admin    
            //if (chkUser.Succeeded)
            //{
            //    var result1 = await _userManager.AddToRoleAsync(userx, "Admin");
            //}
            //_signInManager.PasswordSignInAsync()


            //  Claim claim = new Claim(ClaimTypes.Email, "test@test.com");
            //  await _userManager.AddClaimAsync(user, claim);

            //  Claim claim2 = new Claim("Email2", "test@test.com");
            //IdentityResult identityResult = await _userManager.AddClaimAsync(user, claim2);

            // var c1 = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
            // var c2 = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Email2");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            var user = new ApplicationUser { UserName = registerViewModel.Login, Email = registerViewModel.Login };
         
            
            var result = await _userManager.CreateAsync(user, registerViewModel.Pwd);
            if (result.Succeeded)
            {

            }
            else
            {

            }
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
