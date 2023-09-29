using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Employee : BaseEntity<int>
    {
        [Required]
        [DisplayName("Прізвище")]
        public string LastName { get; set; } = null!;
        [Required]
        [DisplayName("Ім'я")]
        public string FirstName { get; set; } = null!;
        [DisplayName("По-батькові")]
        public string? MiddleName { get; set; }
        [DisplayName("Рік народження")]
        public uint? BirthYear { get; set; }
        [DisplayName("Освіта")]
        public string? Education { get; set; }
        [Required]
        [DisplayName("Посада")]
        public string Position { get; set; } = null!;
        [Required]
        [DisplayName("Оклад")]
        public decimal Salaty { get; set; }
        [DisplayName("Підпорядкований")]
        public Employee? Supervisor { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("CategoryId")]
        public Department? Department { get; set; }

    }
}
