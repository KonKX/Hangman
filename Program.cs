using System.Linq;
using Hangman;

Console.Write("WELCOME TO HANGMAN!");

    while (true)
{
    Console.WriteLine(GlobalData.HangmanPics[0]);

    Player player1 = new();
    Word newWord = new(FileManipulator.WordsFromFile(Language.AskLanguage()).PickRandomWord().Trim());

    Console.WriteLine(string.Join(" ", newWord.CurrentWord));

    var i = 0;
    while (player1.Lives > 0 && newWord.StillHasUnknowns == true)
    {
        Console.Write("Please give a letter: ");
        var letterRead = player1.SayLetter();
        var letterExists = newWord.LetterExistsInWord(letterRead);

        if (!letterExists)
        {
            player1.LoseLife();
            GlobalData.DisplayMessage(GlobalData.HangmanPics[++i], player1.LettersSaid, newWord.CurrentWord);
        }
        else
        {
            GlobalData.DisplayMessage(GlobalData.HangmanPics[i], player1.LettersSaid, newWord.CurrentWord);

            if (Array.IndexOf(newWord.CurrentWord, '_') == -1)
            {
                Console.WriteLine("Congrats you found it!");
                newWord.StillHasUnknowns = false;
            }
        }
    }

    Console.WriteLine($"The word was : {newWord.FullWord}\n");
}