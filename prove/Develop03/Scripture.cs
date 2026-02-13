public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitText = text.Split(' ');

        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenSoFar = 0;

        while (hiddenSoFar < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenSoFar++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}