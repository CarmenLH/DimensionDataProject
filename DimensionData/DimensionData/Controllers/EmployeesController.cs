using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DimensionData.Data;
using DimensionData.Models;
using Microsoft.AspNetCore.Authorization;
using DimensionData.Areas;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DimensionData.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DimensionDataContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        public EmployeesController(DimensionDataContext context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Employees
        [Authorize(Policy = "readonlypolicy")]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            var usersOfManager = await _userManager.GetUsersInRoleAsync("Manager");
            var usersOfEmployee = await _userManager.GetUsersInRoleAsync("Employee");
            var usersOfAdmin = await _userManager.GetUsersInRoleAsync("Admin");


            //Define sorting for each column
            ViewData["CurrentSort"] = sortOrder;
            ViewData["EmpNrSortParam"] = sortOrder == "empnr_desc" ? "EmpNr" : "empnr_desc";
            ViewData["EmpAgeSortParam"] = sortOrder == "empage_desc" ? "EmpAge" : "empage_desc";
            ViewData["JobLevelSortParam"] = sortOrder == "joblevel_desc" ? "JobLevel" : "joblevel_desc";
            ViewData["JobRoleSortParam"] = sortOrder == "jobrole_desc" ? "JobRole" : "jobrole_desc";
            ViewData["DepSortParam"] = sortOrder == "dep_desc" ? "Dep" : "dep_desc";
            ViewData["GenderSortParam"] = sortOrder == "gender_desc" ? "Gender" : "gender_desc";

            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            // Resolve the user via their email
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            // Get the roles for the user
            var roles = await _userManager.GetRolesAsync(user);

            if (roles.Contains("Manager") || roles.Contains("Admin"))
            {
               
                var employees = from s in _context.Employee.Include(e => e.Edu).Include(e => e.Emp).Include(e => e.Job) select s;
                //Filter data based on search param
                if (!String.IsNullOrEmpty(searchString))
                {
                    employees = employees.Where(s => s.Job.Department.Contains(searchString)
                                           || s.Job.JobRole.Contains(searchString)
                                           || s.Emp.Gender.Contains(searchString)
                                           || s.Job.JobLevel.ToString() == (searchString)
                                           || s.Emp.Age.ToString() == (searchString)
                                           || s.EmployeeNumber.ToString() == (searchString));
                }

                //Individual Sorting for each column
                switch (sortOrder)
                {
                    case "EmpNr":
                        employees = employees.OrderBy(s => s.EmployeeNumber);
                        break;
                    case "empnr_desc":
                        employees = employees.OrderByDescending(s => s.EmployeeNumber);
                        break;
                    case "EmpAge":
                        employees = employees.OrderBy(s => s.Emp.Age);
                        break;
                    case "empage_desc":
                        employees = employees.OrderByDescending(s => s.Emp.Age);
                        break;
                    case "JobLevel":
                        employees = employees.OrderBy(s => s.Job.JobLevel);
                        break;
                    case "joblevel_desc":
                        employees = employees.OrderByDescending(s => s.Job.JobLevel);
                        break;
                    case "JobRole":
                        employees = employees.OrderBy(s => s.Job.JobRole);
                        break;
                    case "jobrole_desc":
                        employees = employees.OrderByDescending(s => s.Job.JobRole);
                        break;
                    case "Dep":
                        employees = employees.OrderBy(s => s.Job.Department);
                        break;
                    case "dep_desc":
                        employees = employees.OrderByDescending(s => s.Job.Department);
                        break;
                    case "Gender":
                        employees = employees.OrderBy(s => s.Emp.Gender);
                        break;
                    case "gender_desc":
                        employees = employees.OrderByDescending(s => s.Emp.Gender);
                        break;
                    default:
                        employees = employees.OrderBy(s => s.EmployeeNumber);
                        break;
                }

                int pageSize = 10;
                var pagedList = await PaginatedList<Employee>.CreateAsync(employees.AsNoTracking(), pageNumber ?? 1, pageSize);
                return View(pagedList);
            }
            else
            {
                var employees = from s in _context.Employee.Include(e => e.Edu).Include(e => e.Emp).Include(e => e.Job).Where(e => e.Emp.Email == User.Identity.Name) select s;

                int pageSize = 10;
                var pagedList = await PaginatedList<Employee>.CreateAsync(employees.AsNoTracking(), pageNumber ?? 1, pageSize);
                return View(pagedList);
            }
            
        }

        // GET: Employees/Details/5
        [Authorize(Policy = "readonlypolicy")]
        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.GetbyIdAsync(id));
        }

        // GET: Employees/Create
        [Authorize(Policy = "writepolicy")]
        public IActionResult Create()
        {
            ViewData["EducationField"] = new SelectList(_context.EmployeeEducation.Select(x => x.EducationField).Distinct());
            ViewData["BusinessTravel"] = new SelectList(_context.JobInformation.Select(x => x.BusinessTravel).Distinct());
            ViewData["MaritalStatus"] = new SelectList(_context.EmployeeDetails.Select(x => x.MaritalStatus).Distinct());
            ViewData["JobRole"] = new SelectList(_context.JobInformation.Select(x => x.JobRole).Distinct());
            ViewData["Gender"] = new SelectList(_context.EmployeeDetails.Select(x => x.Gender).Distinct());
            ViewData["Department"] = new SelectList(_context.JobInformation.Select(x => x.Department).Distinct());

            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Create(Employee employee)
        {
            return RedirectToAction("Index", await _context.CreateAsync(employee));
        }

        // GET: Employees/Edit/5
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Edit(int? id)
        {
            var employee = await _context.Employee
           .Include(e => e.Emp)
           .Include(e => e.Edu)
           .Include(e => e.EmpHistory)
           .Include(e => e.Job)
           .Include(e => e.Pay)
           .Include(e => e.Survey)
           .Include(e => e.EmpPerformance)
           .FirstOrDefaultAsync(m => m.EmployeeNumber == id);

            if (employee == null)
            {
                return NotFound();
            }

            ViewData["EducationField"] = new SelectList(_context.EmployeeEducation.Select(x => x.EducationField).Distinct());
            ViewData["BusinessTravel"] = new SelectList(_context.JobInformation.Select(x => x.BusinessTravel).Distinct());
            ViewData["MaritalStatus"] = new SelectList(_context.EmployeeDetails.Select(x => x.MaritalStatus).Distinct());
            ViewData["JobRole"] = new SelectList(_context.JobInformation.Select(x => x.JobRole).Distinct());
            ViewData["Gender"] = new SelectList(_context.EmployeeDetails.Select(x => x.Gender).Distinct());
            ViewData["Department"] = new SelectList(_context.JobInformation.Select(x => x.Department).Distinct());

            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Edit(int? id, Employee employee)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", await _context.UpdateAsync(id,employee));
            }

            return View(employee);
        }

        // GET: Employees/Delete/5
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.Edu)
                .Include(e => e.Emp)
                .Include(e => e.EmpHistory)
                .Include(e => e.EmpPerformance)
                .Include(e => e.Job)
                .Include(e => e.Pay)
                .Include(e => e.Survey)
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return RedirectToAction("Index", await _context.DeleteAsync(id));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeNumber == id);
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    }
}
