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

    public int CheckWordContainsLetter()
    {
      int countForLetters = 0;
      for (int i = 0; i < _inputStringToCheck.Length; i++)
      {
        String charToString = _inputStringToCheck[i].ToString();
        if(charToString.Contains(_inputLetterOrWord))
        {
          countForLetters++;
        }
      }
      return countForLetters;
    }
  }
}
