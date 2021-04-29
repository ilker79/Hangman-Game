This game has been created during School of Code adventure.

It is a simple console game. Although it is not complete, it is mostly functional. You can start the game on the terminal with "dotnet run" command. You will be asked to choose a word, then enter letters to guess the word. 

Each letter in the word will be displayed as asterisk(I couldn't put the symbol * here inside double quotes as it changes the font to italic. Actually whatever you add just after * becomes italic). When you guess and if your guess is correct, that letter will appear on the word. If you fail to guess the correct letter the man will start to appear and eventually you will see the below image after 7 wrong guesses. 

 0
/|\
 |
/ \

It's got some bugs to be fixed and then I need to complete the functionality. 

Please let me know what you think.

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

# Real World Representations in Code: Making a Console Game

Games are a great way to think about how to marry the logical steps and problem solving that we've been learning in your time on the course so far with something tangible in real life. Today, we'll make a console version of a familiar game of your choice.

We'd like you to think through how you'd execute some real-life games in code. First, write a high-level plan about what you would need logic-wise and how you can break it all the way down for your game to make it playable. Remember that we've already done this for rock-paper-scissors with code, so cast your mind back to how you broke down the logic of that game into such simple chunks and steps that a computer could understand it.

Start simple with the MVP of your game (the minimum that you'd need to make it playable), and then you can build outward from there. And this time, start taking the power of OOP into account in how you can break down your logic into objects and classes.

Your plan needs to take into account things like:

- **Setup** (Do you need a board? Pieces? What will the game look like when the players begin? What classes do you need to set up, e.g. board, pieces?)
- **Players** (How many players? How will your Players class(es) work? Do they take turns? How will you track each player's score?)
- **States and behaviours** (How will you keep track of the state of the game with each turn or as the flow of the game is progressing? Which classes would need to know/control which aspects of the game? What properties and methods might you use do do this, and where?)
- **Loops and logic** (What loops and other logic will you need to execute the functions you need to play the game? How will you incorporate this into methods on your classes?)
- **Win conditions** (How do you define what it means to win? How do you know when to declare a winner and end the game? Where will this be tracked/changed?)
- **...and more!** (What else do you need for the specific game to make a code version of it playable?)

### Games:

You're by no means limited to the following list! This is just to get you started if you're drawing a blank:

- Tic tac toe
- Snap
- Go Fish
- Top Trumps
- Hangman
- Connect Four
- Checkers
- I Spy
- Scrabble
- Yahtzee
- Snakes and ladders
- Minesweeper
- Uno
- Poker
- Chess
- Guess Who
- Scattergories
- Darts
- Monopoly
- Super Mario

### Start planning how you'd translate your game to code!

👉 Write your plan for how you'd break down your chosen game below into a console game (playable with inputs in your terminal). Diagram out the structure of your classes, states, and behaviors for each game so you know exactly what's going on when you start coding.
