using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DimensionData.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DimensionData.Controllers
{
    //[Authorize(Policy = "writepolicy")]
    public class DataAnalyticsController : Controller
    {
        private readonly DimensionDataContext _context;

        public DataAnalyticsController(DimensionDataContext context)
        {
            _context = context;
        }

        public IActionResult DimensionCharts()
        {
            #region PieChart
            int female = _context.Employee.Where(s => s.Emp.Gender == "Female").Select(s => s).Count();
            int male = _context.Employee.Where(s => s.Emp.Gender == "male").Select(s => s).Count();

            ViewBag.FEM = female;
            ViewBag.MA = male;
            #endregion PieChart

            #region BarChart
            int overSixty = _context.Employee.Where(a => a.Emp.Age >= 60).Select(a => a).Count();
            int underTwenties = _context.Employee.Where(a => a.Emp.Age < 20).Select(a => a).Count();
            int twenties = _context.Employee.Where(a => a.Emp.Age >= 20 && a.Emp.Age < 30).Select(a => a).Count();
            int thirties = _context.Employee.Where(a => a.Emp.Age >= 30 && a.Emp.Age < 40).Select(a => a).Count();
            int fourties = _context.Employee.Where(a => a.Emp.Age >= 40 && a.Emp.Age < 50).Select(a => a).Count();
            int fifties = _context.Employee.Where(a => a.Emp.Age >= 50 && a.Emp.Age < 60).Select(a => a).Count();
            

            ViewBag.UT = underTwenties;
            ViewBag.TW = twenties;
            ViewBag.TH = thirties;
            ViewBag.FO = fourties;
            ViewBag.FI = fifties;
            ViewBag.OS = overSixty;
            #endregion BarChart

            return View();
        }
    }
}
