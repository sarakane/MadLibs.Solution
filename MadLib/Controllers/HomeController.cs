using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/2")]
    public ActionResult Form() { return View(); }

    [Route("/1")]
    public ActionResult NewForm() { return View(); }

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
      return View(userWordVariable); 
    }

    [Route("/newstory")]
    public ActionResult NewStory(string name, string spaceplace1, string number, string emotion1, string emotion2, string miss1, string miss2, string spaceattraction, string color, string spaceplace2, string bignumber, string animalplural, string thing, string homeplanet) 
    { 
      NewWordVariables userNewWordVariables = new NewWordVariables();
      userNewWordVariables.Name = name;
      userNewWordVariables.SpacePlace1 = spaceplace1;
      userNewWordVariables.Number = number;
      userNewWordVariables.Emotion1 = emotion1;
      userNewWordVariables.Emotion2 = emotion2;
      userNewWordVariables.Miss1 = miss1;
      userNewWordVariables.Miss2 = miss2;
      userNewWordVariables.SpaceAttraction = spaceattraction;
      userNewWordVariables.Color = color;
      userNewWordVariables.SpacePlace2 = spaceplace2;
      userNewWordVariables.BigNumber = bignumber;
      userNewWordVariables.AnimalPlural = animalplural;
      userNewWordVariables.Thing = thing;
      userNewWordVariables.HomePlanet = homeplanet;       
      return View(userNewWordVariables); 
    }


  }
}
