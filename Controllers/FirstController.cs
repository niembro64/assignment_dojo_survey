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
    [Route("")] // empty is front page
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


    [HttpGet("form")]
    public ViewResult Form()
    {
      return View();
    }

    [HttpPost("postForm")]
    public IActionResult postForm(string name, string color, int number){
      Console.WriteLine($"name: {name}");
      Console.WriteLine($"color: {color}");
      Console.WriteLine($"number: {number}");
      ViewBag.name = name;
      ViewBag.color = color;
      ViewBag.number = number;
      return View("Success");
      // return RedirectToAction("Success");
    }

    [HttpGet("Success")]
    public IActionResult Success(){
      return View();
    }


  }

}