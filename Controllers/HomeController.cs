using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_deneme_2.Models;

namespace mvc_deneme_2.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View(Repository.Movies);
  }
  public IActionResult Contact()
  {
    return View();
  }
}
