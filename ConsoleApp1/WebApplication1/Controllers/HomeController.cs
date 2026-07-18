using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Name"] = "John Raven J. Eullo";
        ViewData["Title"] = "Student";
        ViewData["Intro"] = "I am an IT Student in Lyceum of Alabang, and I have a desire to create programs that can change a company or a person's life.";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewData["Bio1"] = "I am an only child who was born on June 21, 2004, and lives in Muntinlupa City. I am a student who craves knowledge and loves teaching others. As an Information Technology student, I am continuously developing my knowledge in programming, web development, databases, and other areas of technology.";
        ViewData["Bio2"] = "My career goals are to become a Game Developer and a Content Moderator. I want to create meaningful programs and digital experiences that can positively impact a company or a person's life.";
        ViewData["Ed1"] = "BS Information Technology | Lyceum of Alabang | 2024 - Present";
        ViewData["Ed2"] = "Senior High School | Lakeview Integrated School | 2020 - 2022";
        ViewData["Ed3"] = "Junior High School | Lakeview Elementary School | 2016 - 2020";
        ViewData["Goals"] = "Game Developer and Content Moderator";
        return View();
    }

    public IActionResult Skills()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Email"] = "eulloraven@gmail.com";
        ViewData["Mobile"] = "09568729329";
        ViewData["GitHub"] = "github.com/EulloJohnRaven";
        ViewData["LinkedIn"] = "linkedin.com/in/raven-eullo-ba92123b5/";
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}