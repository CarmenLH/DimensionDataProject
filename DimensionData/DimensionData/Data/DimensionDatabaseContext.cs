using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DimensionData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DimensionData.Data
{
    public class DimensionDatabaseContext : DbContext
    {
        public DimensionDatabaseContext(DbContextOptions<DimensionDatabaseContext> options) : base(options)
        {
           
        }

        public DbSet<EmployeeModel> dataSet { get; set; }

        //Get the details of each employee by id
        public async Task<EmployeeModel> GetbyIdAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await dataSet.FirstOrDefaultAsync(emp => emp.ListID == id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return employeeModel;
        }

        //Edit the data of an employee
        public async Task<EmployeeModel> UpdateAsync(int? id, EmployeeModel employee)
        {
            if (id != employee.ListID)
            {
                return NotFound();
            }

            try
            {
                Update(employee);
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeModelExists(employee.ListID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return employee;
        }

        //Create a new data entry
        public async Task<EmployeeModel> CreateAsync(EmployeeModel employee)
        {
            Add(employee);
            await SaveChangesAsync();
            return employee;
        }

        //Delete an existing data entry
        //public async Task DeleteAsync(int? id)
        //{
        //    //await employees.DeleteOneAsync(emp => emp.id == id);
        //    dataSet.Remove(await dataSet.FindAsync(id));
        //    await SaveChangesAsync();
        //}

        //Data check methods
        private EmployeeModel NotFound()
        {
            throw new NotImplementedException();
        }
        private bool EmployeeModelExists(int id)
        {
            return dataSet.Any(e => e.ListID == id);
        }
    }
}
