using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controllers
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story() 
    { 
      WordVariable userWordVariable = new WordVariable();
      userWordVariable.
      return View(); 
      }
  }



}