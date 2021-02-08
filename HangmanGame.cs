using System;
using System.Collections.Generic;


public class HangmanGame
{

    public string ChosenWord;
    public string WordChooser;
    // List<Player> GuesserPlayer = new List<Player>();
    public string GuesserPlayer;
    public List<char> AtoZ = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    public HangmanGame(string guesserPlayer, string wordChooser)
    {
        // foreach (string name in guesserPlayer)
        // {
        //     GuesserPlayer.Add(new Player(name));

        // }
        GuesserPlayer = guesserPlayer;

        WordChooserPlayer WordChooser = new WordChooserPlayer(wordChooser);

    }

    public void Play()
    {

        Console.WriteLine($"{WordChooserPlayer.Name}, please type a word and press return");
        ChosenWord = WordChooserPlayer.DefineTheWord();
        Console.WriteLine($"{GuesserPlayer}, the word which has been chosen for you is \n {ChosenWord}");

        while (true)
        {
            Player.ChooseLetter();
            CheckAndGuess.CheckTheLetter();
            Console.WriteLine("wrong answer: " + CheckAndGuess.wrongAnswer);


        }

    }

}




