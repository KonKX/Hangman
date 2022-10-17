class Language
{
    public static string AskLanguage()
    {
        var lang = "";
        while (true)
        {
            Console.Write("\nPlease choose your language (gr, en): ");
            lang = Console.ReadLine();
            if (lang is "gr" or "en") break;
        }
        Console.WriteLine($"Dictionary selected in {(lang == "en" ? "english" : "greek")}\n");
        return lang;
    }
}