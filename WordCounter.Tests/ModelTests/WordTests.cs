using Microsoft.VisualStudio.TestTools.UnitTesting;
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

  }
}
