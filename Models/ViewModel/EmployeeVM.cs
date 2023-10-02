using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Models.ViewModel
{
    public class EmployeeVM
    {
        public Employee Employee { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<SelectListItem> DepartmentList { get; set; } = null!;
        public IEnumerable<SelectListItem> EployeeList { get; set; } = null!;
    }
}
