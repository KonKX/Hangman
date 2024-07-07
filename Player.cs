public class Player
{
    public int Lives { get; private set; } = 6;
    public List<char> LettersSaid { get; set; }
    public Player()
    {
        LettersSaid = new List<char>();
    }
    public void LoseLife()
    {
        this.Lives--;
    }

    public char SayLetter()
    {
        char letterRead;
        do
        {
            letterRead = Console.ReadKey().KeyChar;
        } while (letterRead.Equals(""));

        if (!LettersSaid.Contains(letterRead))
            LettersSaid.Add(letterRead);
        return letterRead;
    }
}