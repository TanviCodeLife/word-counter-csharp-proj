using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsControllerTest
  {

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      WordsController controller = new WordsController();

      //Act
      ActionResult newView = controller.New();

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    [TestMethod]
    public void Result_ReturnsCorrectActionType_True()
    {
      //Arrange
      WordsController controller = new WordsController();

      //Act
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      ActionResult resultView = controller.Result(inputLetterOrWord, inputStringToCheck);

      //Assert
      Assert.IsInstanceOfType(resultView, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Result_RedirectsToCorrectAction_New()
    {
      //Arrange
      WordsController controller = new WordsController();
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      RedirectToActionResult actionResult = controller.Result(inputLetterOrWord, inputStringToCheck) as RedirectToActionResult;

      //Act
      string resultName = actionResult.ActionName;

      //Assert
      Assert.AreEqual(resultName, "New");
    }



  }
}
