using DimensionData.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimensionData.Services
{
    public class EmployeeServices
    {
        private readonly IMongoCollection<EmployeeModel> employees;

        public EmployeeServices(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            employees = database.GetCollection<EmployeeModel>("Employees");
        }

        public async Task<List<EmployeeModel>> GetAllAsync(/*int page, int pageSize*/)
        {
            return await employees.Find(emp => true).ToListAsync();
            //return await employees.Find(new BsonDocument()).Skip((page - 1) * pageSize).Limit(pageSize).SortBy(emp => emp.EmployeeNumber).ToListAsync();
        }

        public async Task<EmployeeModel> GetbyIdAsync(string id)
        {
            return await employees.Find<EmployeeModel>(emp => emp.id == id).FirstOrDefaultAsync();
        }

        public async Task<EmployeeModel> CreateAsync(string id, EmployeeModel employee)
        {
            await employees.InsertOneAsync(employee);
            return employee;
        }

        public async Task UpdateAsync(string id, EmployeeModel employee)
        {
            await employees.ReplaceOneAsync(emp => emp.id == id, employee);
        }

        public async Task DeleteAsync(string id)
        {
            await employees.DeleteOneAsync(emp => emp.id == id);
        }
    }
}
