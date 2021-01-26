using System;

public class HangmanGame
{
    public int NumberOfPlayers;
    public var AtoZ = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    public HangmanGame(int numberOfPlayers)
    {
        NumberOfPlayers = numberOfPlayers;
    }

    public checkAvailableLeters(char chosenLetter)
    {
        //take a char as an input
        //check char against AtoZ list
        //if char is in AtoZ list, then remove from AtoZ list
        //else print "you have already chosen that letter, please choose another letter"
        //let the player choose another letter
    }



}