using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DimensionData.Models;
using DimensionData.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DimensionData.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        private readonly ILogger<EmployeeController> _logger;
        private readonly EmployeeServices _services;
        private readonly IMongoCollection<EmployeeModel> employees;


        public EmployeeController(ILogger<EmployeeController> logger, EmployeeServices services)
        {
            _logger = logger;
            _services = services;
        }

        // GET: Employee Data
        public async Task<IActionResult> EmployeeData()
        {
            var data = await _services.GetAllAsync();
            return View(data);
        }

        // GET: EmployeeController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            return View(await _services.GetbyIdAsync(id));
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string id, EmployeeModel employee)
        {
            await _services.CreateAsync(id, employee);
            return View();
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, EmployeeModel employee)
        {
            //if (ModelState.IsValid)
            //{
            //    await _services.UpdateAsync(id, employee);
            //    return RedirectToAction("EmployeeData");
            //}
            //return View();
            try
            {
                await _services.UpdateAsync(id, employee);
                return RedirectToAction("EmployeeData");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if(ModelState.IsValid)
            {
                //await _services.DeleteAsync(id);
                //ViewBag.Message = "Record Deleted Successfully.";
                await _services.GetbyIdAsync(id);
                return RedirectToAction("EmployeeData");
            }
            else
            {
                return View();
            }

            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
