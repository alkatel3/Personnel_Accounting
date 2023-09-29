using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class DepartmentRepository : Repository<int, Department>
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
