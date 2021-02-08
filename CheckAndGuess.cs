using System;

public class CheckAndGuess
{
    public static int wrongAnswer = 0;
    static string theMan = "";
    public static void CheckTheLetter()
    {
        // Console.WriteLine(WordChooserPlayer.Word);
        string wordRecieved = WordChooserPlayer.Word;
        char letterRecieved = Player.LetterChosen;
        char[] convertedWordRecieved = WordChooserPlayer.ConvertedWord;
        bool elseIf = false;

        for (int i = 0; i < wordRecieved.Length; i++)
        {
            if (letterRecieved == wordRecieved[i])
            {
                convertedWordRecieved[i] = letterRecieved;
                elseIf = true;
            }
        }

        if (elseIf == false)
        {
            wrongAnswer++;
            if (wrongAnswer - 1 == 0 || wrongAnswer - 1 == 4)
            {
                theMan += " " + Hanger.HangTheMan(wrongAnswer - 1).ToString() + "\n";
            }
            else if (wrongAnswer - 1 == 3)
            {
                theMan += Hanger.HangTheMan(wrongAnswer - 1).ToString() + "\n";
            }
            else if (wrongAnswer - 1 == 5)
            {
                theMan += Hanger.HangTheMan(wrongAnswer - 1).ToString() + " ";
            }
            else
            {
                theMan += Hanger.HangTheMan(wrongAnswer - 1).ToString();
            }


        }
        Console.WriteLine(theMan);

        Console.WriteLine(convertedWordRecieved);

    }

    public static void CheckTheWord()
    {

    }
}
