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
    public void ConvertStringToLowerCase_ConvertInputSentenceWordToLower_LowerCaseString()
    {
      //Arrange
      string inputLetterOrWord = "a";
      string inputStringToCheck = "CATAN";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string actualConvertedStringToLower = testWord.ConvertStringToLowerCase();
      string expectedStringAfterLower = "catan";

      //Assert
      Assert.AreEqual(expectedStringAfterLower, actualConvertedStringToLower);
    }

    [TestMethod]
    public void ConvertLetterOrWordToLowerCase_ConvertToLower_LowerCaseString()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "cat";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string actualConvertedLetterToLower = testWord.ConvertLetterOrWordToLowerCase();
      string expectedLetterAfterLower = "a";

      //Assert
      Assert.AreEqual(expectedLetterAfterLower, actualConvertedLetterToLower);
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
      int actualCount = testWord.CheckWordContainsLetterToGetCount(inputLetterOrWord, inputStringToCheck);

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
      string convertedLetterToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      int actualCount = testWord.CheckWordContainsLetterToGetCount(convertedLetterToLower, convertedStringToLower);

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
      List<string> actualListFromSentence = new List<string>{};
      actualListFromSentence = testWord.ConvertSentenceToList(inputStringToCheck);

      //Assert
      CollectionAssert.AreEqual(expectedListFromSentence, actualListFromSentence);
    }

    [TestMethod]
    public void CheckSentenceContainsWordToGetCount_CheckCountofMatchInSentence_Count()
    {
      //Arrange
      string inputLetterOrWord = "cat";
      string inputStringToCheck = "there is a black cat and a white cat";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int expectedCount = 2;
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList(inputStringToCheck);
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence, inputLetterOrWord);

      //Assert
      Console.WriteLine("expected:" + expectedCount + " actual:" + actualCount);
      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void CheckSentenceContainsWordToGetCountMixedCase_CheckCountofMatchInSentence_Count()
    {
      //Arrange
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int expectedCount = 2;
      string convertedLetterToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList(convertedStringToLower);
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence, convertedLetterToLower);

      //Assert
      Console.WriteLine("expected:" + expectedCount + " actual:" + actualCount);
      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void PickBetweenLetterOrWordMatch_CheckCountofMatchInSentence_Count()
    {
      //Arrange
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in a cathedral";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int expectedCount = 2;
      string convertedLetterToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList(convertedStringToLower);
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence, convertedLetterToLower);

      //Assert
      Console.WriteLine("expected:" + expectedCount + " actual:" + actualCount);
      Assert.AreEqual(expectedCount, actualCount);
    }

  }
}
