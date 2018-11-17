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

    public string ConvertStringToLowerCase(){
      string stringToCheck = _inputStringToCheck.ToLower();
      return stringToCheck;
    }

    public string ConvertLetterOrWordToLowerCase(){
      string letterOrWord = _inputLetterOrWord.ToLower();
      return letterOrWord;
    }

    public int CheckWordContainsLetterToGetCount(string inputLetter, string inputString)
    {
      int countForLetters = 0;
      for (int i = 0; i < inputString.Length; i++)
      {
        String charToString = inputString[i].ToString();

        if(charToString == inputLetter)
        {
          countForLetters++;
        }
      }
      return countForLetters;
    }


    public List<string> ConvertSentenceToList(string stringToCheck)
    {
      string[] inputArrayToCheck = stringToCheck.Split(' ');
      List<string> listFromSentencetoCompare = new List<string>(inputArrayToCheck);
      return listFromSentencetoCompare;
    }

    public int CheckSentenceContainsWordToGetCount(List<string> listFromSentence, string letterOrWordToFind)
    {
      int countForWords = 0;
      foreach (string wordToCompare in listFromSentence)
      {
        if(wordToCompare == letterOrWordToFind)
        {
          countForWords++;
        }
      }
      return countForWords;
    }

   // public int CheckIfInputStringHasSpecialChar()
   // {
   //   string[] source = text.Split('.', '?', '!', ' ', ';', ':', ',', '\'');
   // }

  }
}
