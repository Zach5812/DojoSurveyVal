﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost("addStudent")]
    public IActionResult AddStudent(Student newStudent) 
    {
        if(!ModelState.IsValid)
        {
            return View("index");
        }
        Console.WriteLine($"{newStudent.Name} {newStudent.Location} {newStudent.Language}");
        ViewBag.Name = newStudent.Name;
        ViewBag.Location = newStudent.Location;
        ViewBag.Language = newStudent.Language;
        return View("Results", newStudent);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}