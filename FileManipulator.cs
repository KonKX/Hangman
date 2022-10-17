public static class FileManipulator
{
    public static string[] WordsFromFile(string language)
    {
        switch (language)
        {
            case "gr":
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                if (File.Exists("hangman_dict_gr.txt"))
                {
                    return File.ReadAllLines("hangman_dict_gr.txt");
                }

                break;
            }
            case "en" when File.Exists("hangman_dict_en.txt"):
                return File.ReadAllLines("hangman_dict_en.txt");
        }

        throw new InvalidOperationException();
    }

    public static string PickRandomWord(this string[] words)
    {
        Random rnd = new Random();
        return words[rnd.Next(words.Length)];
    }
}