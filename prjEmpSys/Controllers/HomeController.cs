using Microsoft.AspNetCore.Mvc;
using prjEmpSys.Models; 

namespace prjEmpSys.Controllers
{
    public class HomeController : Controller
    {
        private EmpDbContext _context;

        public HomeController(EmpDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.TEmployees.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TEmployee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.TEmployees.Add(employee);
                    _context.SaveChanges();
                    TempData["Success"] = "員工記錄新增成功";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["Error"] = "員工編號重複";
                }
            }

            return View(employee);

        }

        public IActionResult Delete(string id)
        {
            var employee = _context.TEmployees.FirstOrDefault(m => m.EmpId == id);
            _context.TEmployees.Remove(employee);
            _context.SaveChanges();
            TempData["Success"] = "員工記錄刪除成功";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id) 
        {
            var employee = _context.TEmployees.FirstOrDefault(m => m.EmpId == id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(TEmployee employee)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    string empId = employee.EmpId;
                    
                    var temp = _context.TEmployees.FirstOrDefault(m => m.EmpId == empId);
                    temp.Name = employee.Name;
                    temp.Gender = employee.Gender;
                    temp.Mail = employee.Mail;
                    temp.Salary = employee.Salary;
                    temp.OnBoard = employee.OnBoard;
                    
                    _context.SaveChanges();
                    TempData["Success"] = "員工記錄修改成功";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["Error"] = "員工記錄無法修改，請重新檢視修改資料";
                }
            }

            return View(employee);
        }
    }
}
