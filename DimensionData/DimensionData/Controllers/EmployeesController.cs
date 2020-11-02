using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DimensionData.Data;
using DimensionData.Models;

namespace DimensionData.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DimensionDataContext _context;

        public EmployeesController(DimensionDataContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            //Define sorting for each column
            ViewData["CurrentSort"] = sortOrder;
            ViewData["EmpNrSortParam"] = sortOrder == "empnr_desc" ? "EmpNr" : "empnr_desc";
            ViewData["EmpAgeSortParam"] = sortOrder == "empage_desc" ? "EmpAge" : "empage_desc";
            ViewData["JobLevelSortParam"] = sortOrder == "joblevel_desc" ? "JobLevel" : "joblevel_desc";
            ViewData["JobRoleSortParam"] = sortOrder == "jobrole_desc" ? "JobRole" : "jobrole_desc";
            ViewData["DepSortParam"] = sortOrder == "dep_desc" ? "Dep" : "dep_desc";
            ViewData["GenderSortParam"] = sortOrder == "gender_desc" ? "Gender" : "gender_desc";

            ViewData["CurrentFilter"] = searchString;
            
            return View(await _context.GetAllPagination(sortOrder, currentFilter, searchString, pageNumber));
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.GetbyIdAsync(id));
        }

        // GET: Employees/Create
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
        public async Task<IActionResult> Create(Employee employee)
        {
            return RedirectToAction("Index", await _context.CreateAsync(employee));
        }

        // GET: Employees/Edit/5
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
        public async Task<IActionResult> Edit(int? id, Employee employee)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", await _context.UpdateAsync(id,employee));
            }

            return View(employee);
        }

        // GET: Employees/Delete/5
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
