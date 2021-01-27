using System;
using System.Collections.Generic;
using System.Text;

public class textBox
{
    public string HangmanText;
    public string inGameText;
    public string hiddenText;
    public string hiddenTextU;

    public textBox(string inputText)
    {
        inGameText = inputText;
    }

public void convertText()
{
// convert to hidden text by replacing string as *** 
        int length = inGameText.Length;
        hiddenText = new string('*', length);
        hiddenTextU = hiddenText;
        Console.WriteLine(hiddenTextU);
}

  public void checkLetter(char letterGuess)
  {
      // looks at wordInput
      // checks if contains letter
      // returns boolean type array of 
      // returns false if letter can not be found there 

      foreach(char letter in inGameText)
      {
        if (letter == letterGuess)
          {
            int index = inGameText.IndexOf(letter);
            StringBuilder sb = new StringBuilder(inGameText);
            sb[index] = 'x'; // index starts at 0!
            inGameText = sb.ToString();
          }
      
        else 
            {
           
            }
      }
  }

  public bool checkWord()
  {
      //takes in guessed word and compares with wordInput
      //returns true or false 
      return false;
  }

  public void changeVisibilty(string text, int index, char letter)
  {
      char[] newArray = hiddenTextU.ToCharArray();
      newArray[index] = letter;
      hiddenTextU = newArray.ToString();
      // converts to a string of ***** same length - called hiddenText
      // on each correct guess the appropriate character is changed to show character
      // current state of hiddenText printed 
        Console.WriteLine(hiddenTextU);
  }

} 