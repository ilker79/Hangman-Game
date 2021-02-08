using System;

class WordChooserPlayer
{
    public static string Word;
    public static char[] ConvertedWord;
    public static string Name;
    public WordChooserPlayer(string name)
    {
        Word = "";
        Name = name;

    }

    public static string DefineTheWord()
    {
        Word = Console.ReadLine();
        ConvertedWord = Word.ToCharArray();
        for (int i = 0; i < ConvertedWord.Length; i++)
        {
            ConvertedWord[i] = '*';
        }

        string newStr = new string(ConvertedWord);
        return newStr;
    }
}