using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
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
    public void ConvertSentenceToList_CheckOutputIsListOfWords_List()
    {
      //Arrange
      string inputLetterOrWord = "test";
      string inputStringToCheck = "this is a test";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      List<string> expectedListFromSentence = new List<string>{"this", "is", "a", "test"};
      List<string> actualListFromSentence = new List<string>{}; actualListFromSentence = testWord.ConvertSentenceToList();

      //Assert
      CollectionAssert.AreEqual(expectedListFromSentence, actualListFromSentence);
    }

    [TestMethod]
    public void CheckSentenceContainsWordToGetCount_CheckCountofMatchinSentence_Count()
    {
      //Arrange
      string inputLetterOrWord = "cat";
      string inputStringToCheck = "there is a black cat and a white cat";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int expectedCount = 2;
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList();
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence);

      //Assert
      Console.WriteLine("expected:" + expectedCount + " actual:" + actualCount);
      Assert.AreEqual(expectedCount, actualCount);
    }

  }
}
