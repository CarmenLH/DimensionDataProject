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

//var employee = await _context.Employee
//    .Include(e => e.Emp.Gender)
//    .Include(e => e.Emp.Age)
//    .Include(e => e.Emp.MaritalStatus)
//    .Include(e => e.Emp.Attrition)
//    .Include(e => e.Emp.Over18)
//    .Include(e => e.Emp.DistanceFromHome)
//    .Include(e => e.Edu.Education)
//    .Include(e => e.Edu.EducationField)
//    .Include(e => e.EmpHistory.NumCompaniesWorked)
//    .Include(e => e.EmpHistory.TotalWorkingYears)
//    .Include(e => e.EmpHistory.YearsAtCompany)
//    .Include(e => e.EmpHistory.YearsInCurrentRole)
//    .Include(e => e.EmpHistory.YearsSinceLastPromotion)
//    .Include(e => e.EmpHistory.YearsWithCurrManager)
//    .Include(e => e.EmpHistory.TrainingTimesLastYear)
//    .Include(e => e.Job.JobRole)
//    .Include(e => e.Job.Department)
//    .Include(e => e.Job.JobLevel)
//    .Include(e => e.Job.StandardHours)
//    .Include(e => e.Job.EmployeeCount)
//    .Include(e => e.Job.BusinessTravel)
//    .Include(e => e.Job.StockOptionLevel)
//    .Include(e => e.Pay.HourlyRate)
//    .Include(e => e.Pay.DailyRate)
//    .Include(e => e.Pay.MonthlyRate)
//    .Include(e => e.Pay.MonthlyIncome)
//    .Include(e => e.Pay.OverTime)
//    .Include(e => e.Pay.PercentSalaryHike)
//    .Include(e => e.Survey.EnvironmentSatisfaction)
//    .Include(e => e.Survey.JobSatisfaction)
//    .Include(e => e.Survey.RelationshipSatisfaction)
//    .Include(e => e.EmpPerformance.PerformanceRating)
//    .Include(e => e.EmpPerformance.WorkLifeBalance)
//    .Include(e => e.EmpPerformance.JobInvolvement)
//    .FirstOrDefaultAsync(m => m.EmployeeNumber == id);