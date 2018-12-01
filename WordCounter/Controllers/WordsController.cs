using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/words")] //equals New
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/words-result")] //equals Create
    public ActionResult Result(string inputLetterOrWord, string inputStringToCheck)
    {
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);
      return View(testWord);
    }

    [HttpGet("/words-result")] //equals Index
    public ActionResult AllPlays()
    {
      List<Word> allWords = Word.GetAll();
      return View("x", allWords);

    }


  }
}
