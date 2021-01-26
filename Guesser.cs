using System;

public class Guesser : HangmanGame
{
    public bool Alive;
    public int PlayerLive;
    public Guesser(int numberOfPlayers) : base(numberOfPlayers)
    {
        Alive = true;
        PlayerLive = 8;

    }

    public static char ChooseLetter()
    {
        Console.WriteLine("Please choose a letter:");
        char readLn = Convert.ToChar(Console.Read());

        return readLn;
    }







}