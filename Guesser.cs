using System;

public class Guesser : HangmanGame
{
    public bool Alive;
    public int PlayerLives;
    public Guesser(int numberOfPlayers) : base(numberOfPlayers)
    {
        Alive = true;
        PlayerLives = 8;

    }

    public static char ChooseLetter()
    {
        Console.WriteLine("Please choose a letter:");
        char readLn = Convert.ToChar(Console.Read());

        return readLn;
    }







}