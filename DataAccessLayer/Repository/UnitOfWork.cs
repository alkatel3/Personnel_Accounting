﻿using DataAccessLayer.Entities;
using DataAccessLayer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private IRepository<int, Employee> _employees;
        private IRepository<int, Department> _departments;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepository<int, Employee> Employees
        {
            get
            {
                if (_employees == null)
                    _employees = new EmployeeRepository(_context);

                return _employees;
            }
        }

        public IRepository<int, Department> Departments
        {
            get
            {
                if (_departments == null)
                    _departments = new DepartmentRepository(_context);

                return _departments;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}