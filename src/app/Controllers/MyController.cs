using System.Web;
using Microsoft.AspNetCore.Mvc; 
 
namespace MvcMovie.Controllers 
{ 
    public class HelloWorldController : Controller 
    { 
        // 
        // GET: /HelloWorld/ 
 
        public string Index() 
        { 
            return "Hello world!"; 
        } 
    } 
}