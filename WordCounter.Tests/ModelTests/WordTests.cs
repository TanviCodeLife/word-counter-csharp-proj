using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest : IDisposable
  {

    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      //Arrange
      Word testWord = new Word("test", "this is a test");

      //Act and Assert
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }

    [TestMethod]
    public void GetInputLetterOrWord_ReturnsUserInputLetterOrWord_String()
    {
      //Arrange
      string inputLetterOrWord = "C";
      string inputStringToCheck = "CAT";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string result = testWord.GetInputLetterOrWord();

      //Assert
      Assert.AreEqual("C", result);
    }

    [TestMethod]
    public void GetInputStringToCheck_ReturnsUserInputStringToCheck_String()
    {
      //Arrange
      string inputLetterOrWord = "C";
      string inputStringToCheck = "CAT";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string resultLetter = testWord.GetInputLetterOrWord();
      string resultStringToCheck = testWord.GetInputStringToCheck();

      //Assert
      Assert.AreEqual("C", resultLetter);
      Assert.AreEqual("CAT", resultStringToCheck);
    }

    [TestMethod]
    public void SetInputLetterOrWordAndStringToCheck_UpdatePropertiesWithLetterandWord_String()
    {
      //Arrange
      string inputLetterOrWord = "C";
      string inputStringToCheck = "CAT";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string updateInputLetter = "A";
      testWord.SetInputLetterOrWord(updateInputLetter);
      string resultLetter = testWord.GetInputLetterOrWord();

      string updateInputStringToCheck = "ATOM";
      testWord.SetInputStringToCheck(updateInputStringToCheck);
      string resultStringToCheck = testWord.GetInputStringToCheck();

      //Assert
      Assert.AreEqual("A", resultLetter);
      Assert.AreEqual("ATOM", resultStringToCheck);
    }

    [TestMethod]
    public void SetInputLetterOrWordAndStringToCheck_UpdatePropertiesWithWordAndSentence_String()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "CAT";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string updateWord = "CAT";
      testWord.SetInputLetterOrWord(updateWord);
      string resultWord = testWord.GetInputLetterOrWord();
      string updateInputStringToCheck = "THIS IS A CAT";
      testWord.SetInputStringToCheck(updateInputStringToCheck);
      string resultStringToCheck = testWord.GetInputStringToCheck();

      //Assert
      Assert.AreEqual("CAT", resultWord);
      Assert.AreEqual("THIS IS A CAT", resultStringToCheck);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_List()
    {
      // Arrange
      List<Word> newWordList = new List<Word> { };

      // Act
      List<Word> result = Word.GetAll();

      // Assert
      CollectionAssert.AreEqual(newWordList, result);
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

      //Assert
      Assert.AreEqual("a", actualConvertedLetterToLower);
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

      //Assert
      Assert.AreEqual("catan", actualConvertedStringToLower);
    }


    [TestMethod]
    public void CheckWordContainsLetterToGetCount_GetCountOfLetter_Int()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "CATAN";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      int actualCount = testWord.CheckWordContainsLetterToGetCount(inputLetterOrWord, inputStringToCheck);

      //Assert
      Assert.AreEqual(2, actualCount);
    }

    [TestMethod]
    public void CheckWordContainsLetterToGetCount_GetCountOfLettersAfterCaseMatch_Int()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "CaTAN";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

       //Act
      string convertedLetterToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      int actualCount = testWord.CheckWordContainsLetterToGetCount(convertedLetterToLower, convertedStringToLower);

       //Assert
      Assert.AreEqual(2, actualCount);
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
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList(inputStringToCheck);
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence, inputLetterOrWord);

      //Assert
      Console.WriteLine("expected:" + 2 + " actual:" + actualCount);
      Assert.AreEqual(2, actualCount);
    }

    [TestMethod]
    public void CheckSentenceContainsWordToGetCount_CheckCountofMatchInSentenceMixedCase_Count()
    {
      //Arrange
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string convertedLetterOrWordToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList(convertedStringToLower);
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence, convertedLetterOrWordToLower);

      //Assert
      Console.WriteLine("expected:" + 2 + " actual:" + actualCount);
      Assert.AreEqual(2, actualCount);
    }

    [TestMethod]
    public void RemoveSpecialCharactersFromInput_CheckCountofMatchInSentenceWithSpecialCharacters_Count()
    {
      //Arrange
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string convertedLetterOrWordToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      string parsedStringToCheck = testWord.RemoveSpecialCharactersFromInput(convertedStringToLower);
      List<string> listFromSentence = new List<string>{};
      listFromSentence = testWord.ConvertSentenceToList(parsedStringToCheck);
      int actualCount = testWord.CheckSentenceContainsWordToGetCount(listFromSentence, convertedLetterOrWordToLower);

      //Assert
      Console.WriteLine("expected:" + 2 + " actual:" + actualCount);
      Assert.AreEqual(2, actualCount);
    }

    [TestMethod]
    public void RunCountParseBasedOnWordOrSentenceInput_SelectFunctionToParseWord_Count()
    {
      //Arrange
      string inputLetterOrWord = "A";
      string inputStringToCheck = "AlamaNaC!!";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string convertedLetterOrWordToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      string parsedStringToCheck = testWord.RemoveSpecialCharactersFromInput(convertedStringToLower);
      int actualCount = testWord.RunCountParseLogicBasedOnWordOrSentenceInput(convertedLetterOrWordToLower, parsedStringToCheck);


      //Assert
      Console.WriteLine("expected:" + 4 + " actual:" + actualCount);
      Assert.AreEqual(4, actualCount);
    }

    [TestMethod]
    public void RunCountParseBasedOnWordOrSentenceInput_SelectFunctionToParseSentence_Count()
    {
      //Arrange
      string inputLetterOrWord = "cAt";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      Word testWord = new Word(inputLetterOrWord, inputStringToCheck);

      //Act
      string convertedLetterOrWordToLower = testWord.ConvertLetterOrWordToLowerCase();
      string convertedStringToLower = testWord.ConvertStringToLowerCase();
      string parsedStringToCheck = testWord.RemoveSpecialCharactersFromInput(convertedStringToLower);
      int actualCount = testWord.RunCountParseLogicBasedOnWordOrSentenceInput(convertedLetterOrWordToLower, parsedStringToCheck);


      //Assert
      Console.WriteLine("expected:" + 2 + " actual:" + actualCount);
      Assert.AreEqual(2, actualCount);
    }

  }
}
