using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using SoftwareDeveloper.Business;

namespace SoftwareDeveloperTest.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBO employeebo = new EmployeeBO();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public JsonResult Consulta(int id)//este es el metodo que me trae los datos
        {

            Task<List<SoftwareDeveloper.Entities.Datum>> lista;
            if (id == 0)
            {
                lista = employeebo.GetEmployeesAsync();
            }
            else
            {
                lista = employeebo.GetEmployeeAsync(id);
            }

            var json = JsonConvert.SerializeObject(lista);
            return Json(new { data = json }, JsonRequestBehavior.AllowGet);
        }

    }
}