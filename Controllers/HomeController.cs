using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppSample.Models;

namespace WebAppSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISchoolActions _schoolActions;

        public HomeController(ISchoolActions schoolActions)
        {
            _schoolActions = schoolActions;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewSchool()
        {
            return View();
        }

        public IActionResult Schools()
        {
            var model = _schoolActions.GetAllSchools();
            return View(model);
        }

        [HttpGet]
        [Route("/School/{schoolId}")]
        public IActionResult School(int schoolId)
        {
            School model = _schoolActions.GetSchool(schoolId);
            return View(model);
        }

        [HttpPost]
        [Route("/New/School")]
        public IActionResult SaveSchool(School schoolData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = _schoolActions.NewSchool(schoolData);
                    return View("School", res);
                }
                else
                    return View("NewSchool");
            }
            catch
            {
                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
