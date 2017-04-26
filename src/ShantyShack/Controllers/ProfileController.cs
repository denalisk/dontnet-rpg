using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ShantyShack.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using ShantyShack.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShantyShack.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ShantyShackDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileController(UserManager<ApplicationUser> userManager, ShantyShackDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var currentProfile = _db.Profiles.FirstOrDefault(profile => profile.User == currentUser);
            currentProfile.User = currentUser;
            return View(currentProfile);
        }

        public IActionResult Test()
        {
            int targetId = 1;
            var thisPerk = _db.Perks.FirstOrDefault(perks => perks.Id == targetId);
            return View(thisPerk);
        }
    }
}
