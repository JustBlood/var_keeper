using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers;

public class HomeController : Controller
{
    public string Index() 
        { 
            return "Hello world!"; 
        } 
}
