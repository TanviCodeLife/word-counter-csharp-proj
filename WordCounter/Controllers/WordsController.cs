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
      string convertedLetterOrWordToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      string parsedStringToCheck = testWord.RemoveSpecialCharactersFromInput(convertedStringToLower);
      int actualCount = testWord.RunCountParseLogicBasedOnWordOrSentenceInput(convertedLetterOrWordToLower, parsedStringToCheck);
      return RedirectToAction("Index");
    }

  }
}
