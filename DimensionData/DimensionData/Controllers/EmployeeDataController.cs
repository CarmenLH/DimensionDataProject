﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DimensionData.Data;
using DimensionData.Models;
using Microsoft.Extensions.Configuration;

namespace DimensionData.Controllers
{
    public class EmployeeDataController : Controller
    {
        private readonly DimensionDatabaseContext _context;

        public EmployeeDataController(DimensionDatabaseContext context)
        {
            _context = context;
        }

        // GET: EmployeeData
        public async Task<IActionResult> Employees()
        {
            return View(await _context.dataSet.ToListAsync());
        }

        // GET: EmployeeData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.GetbyIdAsync(id));
        }

        // GET: EmployeeData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeData/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Employees",await _context.CreateAsync(employee));
            }
            return View();
        }

        // GET: EmployeeData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _context.dataSet.FindAsync(id);
            if (employeeModel == null)
            {
                return NotFound();
            }
            return View(employeeModel);
        }

        // POST: EmployeeData/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Employees", await _context.UpdateAsync(id, employee));
            }
            return View();      
        }

        // GET: EmployeeData/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _context.dataSet
                .FirstOrDefaultAsync(m => m.ListID == id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return View(employeeModel);
        }

        // POST: EmployeeData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var employeeModel = await _context.dataSet.FindAsync(id);
            _context.dataSet.Remove(employeeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Employees");
        }

        private bool EmployeeModelExists(int id)
        {
            return _context.dataSet.Any(e => e.ListID == id);
        }
    }
}
