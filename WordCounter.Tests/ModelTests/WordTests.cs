using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word testWord = new Word("test", "this is a test");
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }

    [TestMethod]
    public void GetInputLetterOrWord_ReturnsUserInputLetterOrWord_String()
    {
      string inputLetterOrWord = "C";
      string inputStringToCheck = "CAT";

      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);
      string result = testWord.GetInputLetterOrWord();
      Assert.AreEqual(inputLetterOrWord, result);
    }

    [TestMethod]
    public void GetInputStringToCheck_ReturnsUserInputStringToCheck_String()
    {
      //Arrange
      string inputLetterOrWord = "C";
      string inputStringToCheck = "CAT";

      //Act
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);
      string resultLetter = testWord.GetInputLetterOrWord();
      string resultStringToCheck = testWord.GetInputStringToCheck();

      //Assert
      Assert.AreEqual(inputLetterOrWord, resultLetter);
      Assert.AreEqual(inputStringToCheck, resultStringToCheck);
    }

    [TestMethod]
    public void SetInputLetterOrWordAndStringToCheck_UpdatePropertiesWithNewStrings_String()
    {
      //Arrange
      string inputLetterOrWord = "C";
      string inputStringToCheck = "CAT";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string updateInputLetterOrWord = "A";
      testWord.SetInputLetterOrWord(updateInputLetterOrWord);
      string resultLetter = testWord.GetInputLetterOrWord();
      string updateInputStringToCheck = "ATOM";
      testWord.SetInputStringToCheck(updateInputStringToCheck);
      string resultStringToCheck = testWord.GetInputStringToCheck();

      //Assert
      Assert.AreEqual(updateInputLetterOrWord, resultLetter);
      Assert.AreEqual(updateInputStringToCheck, resultStringToCheck);
    }

    [TestMethod]
    public void SetInputLetterOrWordAndStringToCheck_UpdatePropertiesWithWordsAndSentence_String()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "CAT";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string updateInputLetterOrWord = "CAT";
      testWord.SetInputLetterOrWord(updateInputLetterOrWord);
      string resultLetter = testWord.GetInputLetterOrWord();
      string updateInputStringToCheck = "THIS IS A CAT";
      testWord.SetInputStringToCheck(updateInputStringToCheck);
      string resultStringToCheck = testWord.GetInputStringToCheck();

      //Assert
      Assert.AreEqual(updateInputLetterOrWord, resultLetter);
      Assert.AreEqual(updateInputStringToCheck, resultStringToCheck);
    }

    [TestMethod]
    public void CheckWordContainsLetter_GetCountOfLetter_Int()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "CATAN";
      int expectedCount = 2;
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int actualCount = testWord.CheckWordContainsLetterToGetCount();

      //Assert
      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void CheckWordContainsLetter_GetCountOfLettersAfterCaseMatch_Int()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "CaTAN";
      int expectedCount = 2;
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int actualCount = testWord.CheckWordContainsLetterToGetCount();

      //Assert
      Assert.AreEqual(expectedCount, actualCount);
    }
  }
}
