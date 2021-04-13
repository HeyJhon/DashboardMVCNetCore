using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemoCharts.Models;

namespace WebApplicationDemoCharts.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public JsonResult DataPastel()
        {
            SeriePastel serie = new SeriePastel();
            return Json(serie.GetDataDummy());
        }

        public JsonResult DataBarras()
        {
            SerieBarra serie = new SerieBarra();
            return Json(serie.GetDataDummy());
        }
    }
}
