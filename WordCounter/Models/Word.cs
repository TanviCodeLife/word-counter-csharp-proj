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

    public string GetInputStringToCheck()
    {
      return _inputStringToCheck;
    }
  }
}
