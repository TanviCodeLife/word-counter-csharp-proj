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
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Result_ReturnsCorrectView_True()
    {
      //Arrange
      WordsController controller = new WordsController();

      //Act
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      ActionResult resultView = controller.Result(inputLetterOrWord, inputStringToCheck);

      //Assert
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }

    [TestMethod]
    public void Result_HasCorrectModelType_Word()
    {
      //Arrange
      WordsController controller = new WordsController();
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      ViewResult resultView = controller.Result(inputLetterOrWord, inputStringToCheck) as ViewResult;

      //Act
      var result = resultView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(object));
    }

    [TestMethod]
    public void AllPlays_ReturnsCorrectView_True()
    {
      //Arrange
      WordsController controller = new WordsController();

      //Act
      ActionResult playsView = controller.AllPlays();

      //Assert
      Assert.IsInstanceOfType(playsView, typeof(ViewResult));
    }

    [TestMethod]
    public void AllPlays_HasCorrectModelType_WordandPhraseList()
    {
      //Arrange
      WordsController controller = new WordsController();
      ViewResult allPlaysView = controller.AllPlays() as ViewResult;

      //Act
      var result = allPlaysView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Word>));
    }

  }
}
