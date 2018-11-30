using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/words")]
    public ActionResult Index()
    {
      List<BagItem> allBagItem = BagItem.GetAll();
      //return View(allBagItem);
      // return new EmptyResult(); Fail CorrectView test
      //return View(0); Fail CorrectModelType Test
    }
  }
}
