namespace WordCounter.Models
{
  public class Word
  {
    private string _inputLetter;
    // private string _inputWord;

    public Word(string inputLetter) //string inputWord to be passed later
    {
      _inputLetter = inputLetter;
      // _inputWord = inputWord;
    }

    public string GetInputLetter()
    {
      return _inputLetter;
    }

  }
}
