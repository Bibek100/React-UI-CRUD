﻿using CrudApp.Models.Repository;
using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Models.DataManager
{
    public class EmployeeManager:IDataRepository<Employee>
    {
        readonly EmployeeContext _employeeContext;
        public EmployeeManager(EmployeeContext context)
        {
            _employeeContext = context;
        }
        public void Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }

        public Employee Get(long id)
        {
            return _employeeContext.Employees
                  .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeContext.Employees.ToList();
        }

        public void Update(Employee dbEntity, Employee entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.Email = entity.Email;
            dbEntity.Document = entity.Document;
            dbEntity.Phone= entity.Phone;

            _employeeContext.SaveChanges();
        }
    }
}
