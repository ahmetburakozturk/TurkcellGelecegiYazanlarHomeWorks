using CoronaParty.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoronaParty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PartyForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PartyForm( PartyAnswer partyAnswer)
        {
            if (ModelState.IsValid)
            {
                return View("PartyForm");
            }
            else
            {
                if (partyAnswer.State == "Evet")
                {
                    return View("Thanks");
                }
                else
                {
                    return View("Sorry");
                }
            }
            
        }
    }
}
