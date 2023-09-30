using DataAccessLayer.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Models.ViewModel;

namespace Personnel_Accounting.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var Employee = _unitOfWork.Employees.GetAll(includeProperties: "Department,Supervisor").ToList();
            return View(Employee);
        }

        public IActionResult Upsert(int? id)
        {
            EmployeeVM employeeVM = new EmployeeVM
            {
                DepartmentList = _unitOfWork.Departments
                .GetAll().Select(d => new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Id.ToString()
                }),
                Employee = new Employee(),
                EployeeList = _unitOfWork.Employees
                .GetAll().Select(e => new SelectListItem
                {
                    Text = string.Join(' ', e.LastName, e.FirstName),
                    Value = e.Id.ToString()
                }),
            };
            if (id == null || id == 0)
            {
                //Create
                return View(employeeVM);
            }
            else
            {
                //Update
                employeeVM.Employee = _unitOfWork.Employees.Get(p => p.Id == id);
                return View(employeeVM);

            }
        }

        [HttpPost]
        public IActionResult Upsert(EmployeeVM employeeVM, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                if (employeeVM.Employee.Id == 0)
                {
                    _unitOfWork.Employees.Add(employeeVM.Employee);
                }
                else
                {
                    _unitOfWork.Employees.UpDate(employeeVM.Employee);
                }

                _unitOfWork.Save();

                TempData["success"] = "Emloyee created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                //productVM = new ProductVM
                //{
                //    CategoryList = UoW.Category
                //    .GetAll().Select(c => new SelectListItem
                //    {
                //        Text = c.Name,
                //        Value = c.Id.ToString()
                //    }),
                //};
                return View(employeeVM);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}