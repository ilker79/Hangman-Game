using System;
using System.Collections.Generic;

public class startGame
{    
    public string wordInputM;

public startGame()
    {
        Console.WriteLine("Enter Player One's Name");
        string creator = Console.ReadLine();
        wordInput(creator);
        Console.WriteLine("Enter Player Two's Name");
        string guesser = Console.ReadLine();   
    }

 public string wordInput(string creator)
    {
        Console.WriteLine($"{creator} please enter your word");
        wordInputM = Console.ReadLine();
        return wordInputM;
    }

public void  wordHangman()
{

}



//write function which starts the game, function excepts 2 parameter as players, one guesser, one word chooser - DONE
//prompt word chooser to enter a word as string - DONE

//put the chosen word in to the word class as an array(split the chosen word to create an array).
//start the Guess loop
//prompt the user to choose a letter. DONE
//check the chosen letter against the list. DONE
//if the letter is in the list, then 
//check the word if it contains the letter.
//remove the letter if it is found, then show the array with letter in correct place.
//else remove a life
//show the array to the player
//prompt the user to choose another letter. DONE            
//break the loop when lives run out or player guesses the word correctly


}