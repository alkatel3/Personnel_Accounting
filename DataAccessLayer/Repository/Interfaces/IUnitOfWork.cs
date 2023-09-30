using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<int, Employee> Employees { get; }
        IRepository<int, Department> Departments { get; }

        void Save();
    }
}
