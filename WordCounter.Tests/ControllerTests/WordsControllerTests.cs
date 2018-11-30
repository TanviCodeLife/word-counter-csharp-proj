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
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      WordsController controller = new WordsController();

      //Act
      ActionResult newView = controller.New();

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

  }
}
