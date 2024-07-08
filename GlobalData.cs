namespace Hangman;

public static class GlobalData
{
    public static string[] HangmanPics { get; } = new string[]
    {
        @"
+ ---+
|    |
     |
     |
     |
     |
=========",
        @"
 +---+
 |   |   
 O   |
     |
     |
     |
=========",
        @"
 +---+
 |   |
 O   |
 |   |
     |
     |
=========",
        @"
 +---+
 |   |
 O   |
/|   |
     |
     |
=========",
        @"
 +---+
 |   |
 O   |
/|\  |
     |
     |
=========",
        @"
 +---+
 |   |
 O   |
/|\  |
/    |
     |
=========",
        @"
 +---+ R
 |   | I
 O   | P
/|\  |
/ \  |
     |
========="
    };

    public static void DisplayMessage(string hangmanPic, List<char> lettersSaid, char[] currentWord)
    {
        Console.WriteLine($"\n{hangmanPic}");
        Console.WriteLine($"Letters said so far: {string.Join(", ", lettersSaid)}\n");
        Console.WriteLine(string.Join(" ", currentWord));
    }
}