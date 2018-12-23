using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myApp.Controllers
{
  public class CustomerController : Controller
  {

    ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      
      return View();
    }
  }
}