using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
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
