namespace Hangman;

public class Word
{
    public string FullWord { get; set; }
    public char[] CurrentWord { get; set; }
    public bool StillHasUnknowns { get; set; } = true;
    public Word(string fullWord)
    {
        this.FullWord = fullWord;
        this.CurrentWord = fullWord.ToCharArray();
        InitCurrentWord();
    }

    public void InitCurrentWord()
    {
        for (var i = 1; i < this.FullWord.Length; i++)
        {
            this.CurrentWord[i] = '_';
        }
    }
    public bool LetterExistsInWord(char letter)
    {
        var exists = false;
        for (var i = 1; i < this.FullWord.Length; i++)
        {
            if (this.FullWord[i] != letter || this.CurrentWord[i] == letter) continue;
            this.CurrentWord[i] = letter;
            exists = true;
        }

        return exists;
    }
}