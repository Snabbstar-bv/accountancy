using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Snabbstar_Education.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Snabbstar_Education.Controllers
{
    public class BoekhoudenController : Controller
    {
        private List<sensor_heat> GetSensors()
        {
            List<sensor_heat> sensor = new List<sensor_heat>();
            sensor.Add(new sensor_heat(1, "Left_Sensor", 22.13));
            sensor.Add(new sensor_heat(2, "Right_Sensor", 23.12));
            return sensor;
        }

        public IActionResult Index()
        {
            ViewData["front_sensor"] = GetSensors();
            return View();
        }

    }
}

