﻿using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Interfaces
{
    internal interface IUnitOfWork
    {
        IRepository<int, Employee> Employees { get; }
        IRepository<int, Department> Departments { get; }

        void Save();
    }
}