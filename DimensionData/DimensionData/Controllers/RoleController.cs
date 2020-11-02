using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DimensionData.Controllers
{
    [Authorize(Policy = "usermanagepolicy")]
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;

        /// 
        /// Injecting Role Manager
        /// 
        /// 
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult RoleIndex()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult CreateRoles()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoles(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("RoleIndex");
        }
    }
}
