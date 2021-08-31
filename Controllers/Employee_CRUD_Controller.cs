using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_LEARNING.Models;
using System.Data.Entity;

namespace MVC_LEARNING.Controllers
{
    public class Employee_CRUD_Controller : Controller
    {
        // GET: Employee_CRUD_
        public ActionResult Index()
        {
            using (EmpDBModels db = new EmpDBModels())
            {
                return View(db.EMPLOYEE_DETAILS.ToList());
            }
            
        }

        // GET: Employee_CRUD_/Details/5
        public ActionResult Details(int id)
        {
            using (EmpDBModels db = new EmpDBModels())
            {
                return View(db.EMPLOYEE_DETAILS.Where(x => x.ID==id).FirstOrDefault());
            }
           
        }

        // GET: Employee_CRUD_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee_CRUD_/Create
        [HttpPost]
        public ActionResult Create(EMPLOYEE_DETAILS employee)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    using (EmpDBModels db = new EmpDBModels())
                    {
                        db.EMPLOYEE_DETAILS.Add(employee);

                        db.SaveChanges();
                    }

                }
                

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                return View();
            }
        }

        // GET: Employee_CRUD_/Edit/5
        public ActionResult Edit(int id)
        {
            using (EmpDBModels db = new EmpDBModels())
            {
                return View(db.EMPLOYEE_DETAILS.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Employee_CRUD_/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EMPLOYEE_DETAILS employee)
        {
            try
            {
                // TODO: Add update logic here
                using (EmpDBModels db = new EmpDBModels())
                {
                    db.Entry(employee).State= EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee_CRUD_/Delete/5
        public ActionResult Delete(int id)
        {
            using (EmpDBModels db = new EmpDBModels())
            {
                return View(db.EMPLOYEE_DETAILS.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Employee_CRUD_/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EMPLOYEE_DETAILS eMPLOYEE)
        {
            try
            {
                // TODO: Add delete logic here
                using (EmpDBModels db = new EmpDBModels())
                {
                    eMPLOYEE = db.EMPLOYEE_DETAILS.Where(x => x.ID == id).FirstOrDefault();
                    db.EMPLOYEE_DETAILS.Remove(eMPLOYEE);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            } 
        }
    }
}
