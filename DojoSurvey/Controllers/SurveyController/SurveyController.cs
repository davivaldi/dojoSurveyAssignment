using System;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class SurveyController : Controller
    {
        [HttpGet("")]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("survey")]

        public IActionResult Survey(string name, string language, string location, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Language = language;
            ViewBag.Location = location;
            ViewBag.Comment = comment;
            
            return View();
        }


    }



}