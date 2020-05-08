using Microsoft.AspNetCore.Mvc;
namespace newweb.Controllers
{
    public class RootController : Controller
    {
        
        public ActionResult SquareRoot()
        {
            return View();
        }
        
        public ActionResult SquareRoot(string firstNumber, string secondNumber)
        {
            return View();
        }

    }
}