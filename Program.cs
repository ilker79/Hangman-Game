using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello Craig");
            // HangmanGame.checkAvailableLeters();
//write function which starts the game, 
    //function excepts 2 parameter as players, one guesser, one word chooser - DONE
//prompt word chooser to enter a word as string.
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

            textBox gamez = new textBox("Bobby");
            string result = gamez.hiddenText;
            Console.WriteLine(result);
            gamez.convertText();
            gamez.changeVisibilty(result, 3,'G');
        }

            // HangmanGame game1 = new HangmanGame(1);
            // game1.checkAvailableLeters();

    }



}