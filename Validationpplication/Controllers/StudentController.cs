using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Validationpplication.Models;

namespace Validationpplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee employee)
        {


            if (employee.Name.Contains("a"))
            {

                ModelState.AddModelError("Name", "Please Enter Test");

            }

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");   

            }
            return View();
        }
    }
}
