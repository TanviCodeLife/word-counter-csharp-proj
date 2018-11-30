using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Word
  {
    private string _inputLetterOrWord;
    private string _inputStringToCheck;
    private int _id;
    private static List<Word> _instances = new List<Word> {};
    private int _count;

    public Word(string inputLetterOrWord, string inputStringToCheck)
    {
      _inputLetterOrWord = inputLetterOrWord;
      _inputStringToCheck = inputStringToCheck;
      _id = _instances.Count;
      _instances.Add(this);
      _count = 0;
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

    public static List<Word> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetId()
    {
      return _id;
    }

    public static Word Find(int searchId)
    {
      return _instances[searchId-1];
    }


    public string ConvertLetterOrWordToLowerCase(){
      string letterOrWord = _inputLetterOrWord.ToLower();
      return letterOrWord;
    }

    public string ConvertStringToLowerCase(){
      string stringToCheck = _inputStringToCheck.ToLower();
      return stringToCheck;
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

    public string RemoveSpecialCharactersFromInput(string stringToParse)
    {
      string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]", "\'"};
      //Iterate the number of times based on the String array length.
      for (int i = 0; i < chars.Length; i++)
      {
        if (stringToParse.Contains(chars[i]))
        {
          stringToParse = stringToParse.Replace(chars[i], "");
        }
      }
      return stringToParse;
    }

    public int RunCountParseLogicBasedOnWordOrSentenceInput(string inputStringToMatch, string inputWordOrSentenceToParse)
    {
      // int count = 0;
      if(inputWordOrSentenceToParse.Contains(" "))
      {
        List<string> listFromSentence = new List<string>{};
        listFromSentence = this.ConvertSentenceToList(inputWordOrSentenceToParse);
        _count = this.CheckSentenceContainsWordToGetCount(listFromSentence, inputStringToMatch);
      }
      else
      {
        _count = this.CheckWordContainsLetterToGetCount(inputStringToMatch, inputWordOrSentenceToParse);
      }
       return _count;
    }

  }
}
