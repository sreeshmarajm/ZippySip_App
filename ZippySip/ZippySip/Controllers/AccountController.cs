﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ZippySip.ViewModels;

namespace ZippySip.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl,
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            var user=await _userManager.FindByNameAsync(loginViewModel.UserName);
            if(user!=null)
            {
                var result=await _signInManager.PasswordSignInAsync(user,loginViewModel.Password,false,false);
                if(result.Succeeded)
                {
                    if(string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                    {
                        return RedirectToAction("Index", "DrinkHome");
                    }
                    else
                    {
                        return Redirect(loginViewModel.ReturnUrl);
                    }
                }
            }
            ModelState.AddModelError("", "Username/Password not found");
            return View(loginViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = loginViewModel.UserName };
                var result= await _userManager.CreateAsync(user,loginViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "DrinkHome");
                }
            }
            return View(loginViewModel);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "DrinkHome");
        }
    }
}
