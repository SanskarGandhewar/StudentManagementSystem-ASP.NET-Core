using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        public ViewResult getListOfData()
        {
            var db = new EmpdbContext();
            List<Emp> emp = db.Emps.ToList();
            //Console.WriteLine(emp);
            return View(emp);
        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Emp emp)
        {
            if (ModelState.IsValid)
            {
                var db = new EmpdbContext();
                db.Emps.Add(emp);
                db.SaveChanges();
                return RedirectToAction("getListOfData");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult EditEmp(int id) 
        {
            var db = new EmpdbContext();
            Emp e = db.Emps.Find(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult EditEmp(Emp emp)
        {
            var db = new EmpdbContext();
            db.Emps.Update(emp);
            db.SaveChanges();
            return RedirectToAction("getListOfData");
        }

        public IActionResult DeleteEmp(int id) 
        {
            var db = new EmpdbContext();
            Emp emp = db.Emps.Find(id);
            db.Emps.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("getListOfData");
        }

    }
}
