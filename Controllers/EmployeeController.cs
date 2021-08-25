using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_LEARNING.Models;

namespace MVC_LEARNING.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 001,
                Name = "MOULY PRASAANTH ARUUGAM",
                Gender = "MALE",
                City = "ERODE"
            };
            return View(employee);
            
        }
    }
}