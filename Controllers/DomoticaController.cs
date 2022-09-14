using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Snabbstar_Education.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Snabbstar_Education.Controllers
{
    public class DomoticaController : Controller
    {
        private List<sensor_heat> GetSensors()
        {
            Object.Db_file database = new Object.Db_file();
            DataTable result = database.queryFunction("SELECT * FROM heat_sensor;");

            List<sensor_heat> sensor = new List<sensor_heat>();
            foreach (DataRow row in result.Rows)
            {

                sensor.Add(new sensor_heat((int)row["id"], (String)row["name"], (double)row["data"]));
                try
                {
                  
                } catch (Exception ignored) {}
            }

            return sensor;
        }

        public IActionResult Index()
        {
            ViewData["front_sensor"] = GetSensors();
            return View();
        }
    }
}

