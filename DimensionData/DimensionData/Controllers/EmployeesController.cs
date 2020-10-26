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
        public async Task<IActionResult> Index()
        {
            //var dimensionDataContext = _context.Employee.Include(e => e.Edu).Include(e => e.Emp).Include(e => e.EmpHistory).Include(e => e.EmpPerformance).Include(e => e.Job).Include(e => e.Pay).Include(e => e.Survey);
            var dimensionDataContext = _context.Employee.Include(e => e.Edu).Include(e => e.Emp).Include(e => e.Job).Include(e => e.Job);
            return View(await dimensionDataContext.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["EduId"] = new SelectList(_context.EmployeeEducation, "EduId", "EduId");
            ViewData["EmpId"] = new SelectList(_context.EmployeeDetails, "EmpId", "EmpId");
            ViewData["EmpHistoryId"] = new SelectList(_context.EmployeeHistory, "EmpHistoryId", "EmpHistoryId");
            ViewData["EmpPerformanceId"] = new SelectList(_context.EmployeePerformance, "EmpPerformanceId", "EmpPerformanceId");
            ViewData["JobId"] = new SelectList(_context.JobInformation, "JobId", "JobId");
            ViewData["PayId"] = new SelectList(_context.CostToCompany, "PayId", "PayId");
            ViewData["SurveyId"] = new SelectList(_context.Surveys, "SurveyId", "SurveyId");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeNumber,PayId,EmpId,EmpHistoryId,EduId,SurveyId,EmpPerformanceId,JobId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EduId"] = new SelectList(_context.EmployeeEducation, "EduId", "EduId", employee.EduId);
            ViewData["EmpId"] = new SelectList(_context.EmployeeDetails, "EmpId", "EmpId", employee.EmpId);
            ViewData["EmpHistoryId"] = new SelectList(_context.EmployeeHistory, "EmpHistoryId", "EmpHistoryId", employee.EmpHistoryId);
            ViewData["EmpPerformanceId"] = new SelectList(_context.EmployeePerformance, "EmpPerformanceId", "EmpPerformanceId", employee.EmpPerformanceId);
            ViewData["JobId"] = new SelectList(_context.JobInformation, "JobId", "JobId", employee.JobId);
            ViewData["PayId"] = new SelectList(_context.CostToCompany, "PayId", "PayId", employee.PayId);
            ViewData["SurveyId"] = new SelectList(_context.Surveys, "SurveyId", "SurveyId", employee.SurveyId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["EduId"] = new SelectList(_context.EmployeeEducation, "EduId", "EduId", employee.EduId);
            ViewData["EmpId"] = new SelectList(_context.EmployeeDetails, "EmpId", "EmpId", employee.EmpId);
            ViewData["EmpHistoryId"] = new SelectList(_context.EmployeeHistory, "EmpHistoryId", "EmpHistoryId", employee.EmpHistoryId);
            ViewData["EmpPerformanceId"] = new SelectList(_context.EmployeePerformance, "EmpPerformanceId", "EmpPerformanceId", employee.EmpPerformanceId);
            ViewData["JobId"] = new SelectList(_context.JobInformation, "JobId", "JobId", employee.JobId);
            ViewData["PayId"] = new SelectList(_context.CostToCompany, "PayId", "PayId", employee.PayId);
            ViewData["SurveyId"] = new SelectList(_context.Surveys, "SurveyId", "SurveyId", employee.SurveyId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeNumber,PayId,EmpId,EmpHistoryId,EduId,SurveyId,EmpPerformanceId,JobId")] Employee employee)
        {
            if (id != employee.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EduId"] = new SelectList(_context.EmployeeEducation, "EduId", "EduId", employee.EduId);
            ViewData["EmpId"] = new SelectList(_context.EmployeeDetails, "EmpId", "EmpId", employee.EmpId);
            ViewData["EmpHistoryId"] = new SelectList(_context.EmployeeHistory, "EmpHistoryId", "EmpHistoryId", employee.EmpHistoryId);
            ViewData["EmpPerformanceId"] = new SelectList(_context.EmployeePerformance, "EmpPerformanceId", "EmpPerformanceId", employee.EmpPerformanceId);
            ViewData["JobId"] = new SelectList(_context.JobInformation, "JobId", "JobId", employee.JobId);
            ViewData["PayId"] = new SelectList(_context.CostToCompany, "PayId", "PayId", employee.PayId);
            ViewData["SurveyId"] = new SelectList(_context.Surveys, "SurveyId", "SurveyId", employee.SurveyId);
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
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeNumber == id);
        }
    }
}
