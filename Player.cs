using System;

class Player
{
    public static string PlayerName;
    public static char LetterChosen;

    public Player(string playerName)
    {
        PlayerName = playerName;

    }

    public static char ChooseLetter()
    {
        Console.WriteLine("Please choose a letter:");
        LetterChosen = Convert.ToChar(Console.ReadLine());
        return LetterChosen;


    }
}