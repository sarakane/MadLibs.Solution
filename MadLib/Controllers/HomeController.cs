using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string person, string adjective1, string adjective2, string adjective3, string noun1, string noun2, string color, string verb1, string verb2, string verb3, string verb4) 
    { 
      WordVariables userWordVariable = new WordVariables();
      userWordVariable.Person = person;
      userWordVariable.Adjective1 = adjective1;
      userWordVariable.Adjective2 = adjective2;
      userWordVariable.Adjective3 = adjective3;
      userWordVariable.Noun1 = noun1;
      userWordVariable.Noun2 = noun2;
      userWordVariable.Color = color;
      userWordVariable.Verb1 = verb1;
      userWordVariable.Verb2 = verb2;
      userWordVariable.Verb3 = verb3;
      userWordVariable.Verb4 = verb4;
      return View(); 
      }
  }



}