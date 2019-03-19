using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;

namespace SalesWeb.Controllers {
    public class DepartmentsController : Controller {
        public IActionResult Index() {
            List<Department> departmentList = new List<Department>();
            departmentList.Add(new Department { Id = 1, Name = "Soccer" });
            departmentList.Add(new Department { Id = 2, Name = "Baseball" });

            return View(departmentList);
        }
    }
}