using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace assignment_dojo_survey.Controllers
{
  public class FirstController : Controller
  {
    // what type of route?

    // get
    [HttpGet]
    // tell it what name of route is
    [Route("index")] // empty is front page
    public ViewResult Index()
    {

      string[] myArray = new string[] { "ciao", "sup", "three" };
      ViewBag.StringArray = myArray;
      // return "Hello from the controller - edited version";
      return View("Index");
    }



    [HttpGet]
    [Route("/second")]
    public ViewResult Second()
    {

      ViewBag.myVariable = "This is coming from my viewbag";
      return View("Second");
    }

    [HttpGet("redirect")]
    public RedirectToActionResult Redirect()
    {
      return RedirectToAction("Second");
    }


    [HttpGet("")]
    public ViewResult Form()
    {
      return View();
    }

    [HttpPost("result")]
    public IActionResult result(string name, string location, string language, string comment){

      ViewBag.name = name;
      ViewBag.location = location;
      ViewBag.language = language;
      ViewBag.comment = comment;
      return View("Success");
      // return RedirectToAction("Success");
    }

    [HttpGet("Success")]
    public IActionResult Success(){
      return View();
    }


  }

}