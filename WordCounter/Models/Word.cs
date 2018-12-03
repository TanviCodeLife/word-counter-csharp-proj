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


    public List<string> ConvertWordToListOfLetters(string inputWord)
    {
      List<string> listOfLetters = new List<string>{};
      foreach(char c in inputWord)
      {
        listOfLetters. Add(c.ToString());
      }
      return listOfLetters;
    }

    public List<string> ConvertSentenceToList(string stringToCheck)
    {
      string[] inputArrayToCheck = stringToCheck.Split(' ');
      List<string> listFromSentencetoCompare = new List<string>(inputArrayToCheck);
      return listFromSentencetoCompare;
    }


    public int CheckSentenceOrWordContainsWordOrLetterToGetCount(List<string> listFromSentenceOrWord, string letterOrWordToFind)
    {
      int countForWordsOrLetters = 0;
      foreach (string wordOrLetterToCompare in listFromSentenceOrWord)
      {
        if(wordOrLetterToCompare == letterOrWordToFind)
        {
          countForWordsOrLetters++;
        }

      }
      return countForWordsOrLetters;
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
      List<string> listFromSentenceOrWord = new List<string>{};
      if(inputWordOrSentenceToParse.Contains(" "))
      {
        listFromSentenceOrWord = this.ConvertSentenceToList(inputWordOrSentenceToParse);
      }
      else
      {
        listFromSentenceOrWord = this.ConvertWordToListOfLetters(inputWordOrSentenceToParse);
      }
      _count = this.CheckSentenceOrWordContainsWordOrLetterToGetCount(listFromSentenceOrWord, inputStringToMatch);
       return _count;
    }

    public int GetCount()
    {
      return _count;
    }

  }
}
