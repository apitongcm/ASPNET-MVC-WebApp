using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return View();
        }

        // return string with parameters
        // http://localhost{port}/[Controller]/[Action]?[Name][Ranking]
        public string Greetings(string name, int ranking)
        {
            return HtmlEncoder.Default.Encode($"  {name}  with the rank of  {ranking} .");
        }

        public string GreetMe(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name} ! How are you today ? here is your number {id}");
        }

        public IActionResult Welcome(string name, string school, int studentId, int numTimes = 1)
        {
            ViewData["Message"] = "Welcome to Awesome Academy " + name + " from " + school + " .Your student issued Id number is " + studentId;
            ViewData["NumTimes"] = numTimes; 

            return View();
        }

        public IActionResult Allowed(string name, int age, int gatePass)
        {
            ViewData["Success"] = "Welcome to the Fantasy RestoBar. You may now enter Mr/Ms. " + name +" your gatepass will be " + gatePass;
            ViewData["Not18"] = "Im very sorry " + name + "you cannot enter , Minors are not allowed to go inside. Since you are still " + age + "years old and considered as minor.";
            ViewData["Age"] = age;

            return View();
        }

     
    }
}