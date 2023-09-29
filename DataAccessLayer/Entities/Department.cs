using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Department : BaseEntity<int>
    {
        [Required]
        [DisplayName("Назва")]
        public string Name { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }
    }
}
