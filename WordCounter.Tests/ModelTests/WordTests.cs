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
      Word testWord = new Word("test");
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }

    [TestMethod]
    public void GetInputLetter_ReturnsUserInputLetter_String()
    {
      string inputLetter = "C";
      Word testWord = new Word(inputLetter);
      string result = testWord.GetInputLetter();
      Assert.AreEqual(inputLetter, result);
    }

  }
}
