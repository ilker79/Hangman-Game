using System;
using System.Collections.Generic;


public class HangmanGame
{
    public int NumberOfPlayers;
    public List<char> AtoZ = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    public HangmanGame(int numberOfPlayers)
    {
        NumberOfPlayers = numberOfPlayers;
    }

    public void checkAvailableLeters()
    {
        //take a char as an input - LINK TO GUESSER INPUT 


        char chosenLetter = Guesser.ChooseLetter();
        bool checking = true;
        bool exists = true;
        while (checking == true)
        {
            exists = AtoZ.Contains(chosenLetter);

            if (exists == true)
            {
                // char found  = AtoZ.Find(item => item == chosenLetter);
                int index = AtoZ.IndexOf(chosenLetter);
                AtoZ.RemoveAt(index);
                // found = '*';
                checking = false;
                foreach (char letter in AtoZ) { Console.Write(letter); };
            }
            else
            {
                Console.WriteLine($"You have already chosen {chosenLetter}, pleae choose another letter");
                chosenLetter = Convert.ToChar(Console.ReadLine());
            }
        }
    }

}




