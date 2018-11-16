using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Word
  {
    private string _inputLetterOrWord;
    private string _inputStringToCheck;

    public Word(string inputLetterOrWord, string inputStringToCheck)
    {
      _inputLetterOrWord = inputLetterOrWord;
      _inputStringToCheck = inputStringToCheck;
    }

    public string GetInputLetterOrWord()
    {
      return _inputLetterOrWord;
    }

    public void SetInputLetterOrWord(string newInputLetterOrWord)
    {
      _inputLetterOrWord = newInputLetterOrWord;
    }

    public string GetInputStringToCheck()
    {
      return _inputStringToCheck;
    }

    public void SetInputStringToCheck(string newInputStringToCheck)
    {
      _inputStringToCheck = newInputStringToCheck;
    }

    public int CheckWordContainsLetterToGetCount()
    {
      int countForLetters = 0;
      string inputString = _inputStringToCheck.ToLower();
      string inputLetter = _inputLetterOrWord.ToLower();
      for (int i = 0; i < inputString.Length; i++)
      {
        String charToString = inputString[i].ToString();

        if(charToString.Contains(inputLetter))
        {
          countForLetters++;
        }
      }
      return countForLetters;
    }

    public List<string> CheckSentenceContainsWordToGetCount()
    {
      int countForWords = 0;
      string[] inputArrayToCheck = _inputStringToCheck.Split(' '); // Call Split method
      // List<string> listFromSentenceToCheck = inputArrayToCheck.OfType<string>().ToList();
      List<string> listFromArray = new List<string>(inputArrayToCheck); // Use List
      // constructor
      return listFromArray;
      // foreach (string item in listFromArray)
      // {
      //   Console.WriteLine($"{item}");
      // }
    }
  }
}
