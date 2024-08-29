// ------ Object Oriented Design -------
// Notes:
//  * Single Responsibility Principle (SRP) - each class having a clear and focused purpose.

// ---- Rock Paper Scissors ----

// Requirements:
// • Two human players compete against each other.
// • Each player *picks Rock, Paper, or Scissors.
// • Depending on the players’ choices, a winner is *determined: Rock beats Scissors, Scissors beats Paper, Paper beats Rock. If both players pick the same option, it is a draw.
// • The game must *display who won the round.
// • The game will keep *running rounds until the window is closed but must *remember the historical
//   record of how many times each player won and how many draws there were.

// Objects (instance of a class)
    // > Player 1
    // > Player 2
    // > RPS game

// Classes
    // -class Player-
        // • Knows the name of the players
        // • Sets player choice
    // -class RPSGame-
        // • Knows game logic and win/end conditions
        // • Knows what players exist - (from -Player-)
        // • Updates the game each round
        // • Display Result
    // -class ScoreRecord-
        // • Knows players Score
        // • Keeps track of round winner and historical game records

// In summary - a Player 1 and Player 2 will be instantiated along with a new RPSGame. There will be 3 classes (Player, RPSGame, ScoreRecord) these 3 classes will handle the requirements with methods within each.


// ---- 15 Puzzle ----

// Requirements
// • The player needs to be able to *manipulate the board to rearrange it.
// • The current state of the game needs to be *displayed to the user.
// • The game needs to *detect when it has been solved and tell the player they won.
// • The game needs to be able to *generate random puzzles to solve.
// • The game needs to *track and *display how many moves the player has made.

// Objects
    // > Player
    // > GameBoard
    
// Classes
    // -class Player-
        // • Take user commands - (from -Console-)
    // -class GeneratePuzzle-
        // • Generate random puzzle (moved into its own class to handle complexity and board changes)
    // -class GameBoard-
        // • Manipulate and track gameboard - (from -Player-)
        // • Display round
        // • Display state of game board
        // • Track move count
        // • Know game end condition and tell the player win/lose - (-Player-)


// ---- Hangman ----

// Requirements
// • The game *picks a word at random from a list of words.
// • The game’s state is *displayed to the player.
// • The player can *pick a letter. If they pick a letter they already chose, pick again.
// • The game should *update its state based on the letter the player picked.
// • The game needs to *detect a win for the player (all letters have been guessed).
// • The game needs to *detect a loss for the player (out of incorrect guesses).

// Objects
    // > Player
    // > GameManager

// Classes
    // -class Player-
        // • Take user input: pick a letter logic - (from -Console-)
    // -class GenerateWord-
        // • Generates word for the game
    // -class GameManager -
        // • Displays initial game - (from -GenerateWord-)
        // • Update and display state after user guess - (from -Player-)
        // • Detect Win logic
        // • Detect Loss logic


// ---- Tic-Tac-Toe ----

// Requirements
// • Two human players take turns *entering their choice using the same keyboard.
// • The players *designate which square they want to play in. Hint: You might consider using the number
//   pad as a guide. For example, if they enter 7, they have chosen the top left corner of the board.
// • The game should *prevent players from choosing squares that are already occupied. If such a move
//   is attempted, the player should be told of the problem and given another chance.
// • The game must *detect when a player wins or when the board is full with no winner (draw/”cat”).
// • When the game is over, the outcome is displayed to the players.
// • The state of the board must be displayed to the player after each play. 

// Objects
    // > Player 1
    // > Player 2
    // > GameManager

// Classes
    // -class Player-
        // • Take user input: pick a square logic - (from -Console-)
        // • Handle invalid choices (possibly move within GameManager)
    // -class GameDisplay -
        // • Displays state of the board after each play - (from -Player-)
    // -class GameManager -
        // • Determine player turn
        // • Prevent player choosing occupied square
        // • Detect game condition win/draw
        // • Display outcome of the game

GameDisplay newDisplay = new GameDisplay();
newDisplay.RenderBoard();

GameManager newGame = new GameManager();
newGame.ValidateMove();

class GameManager {
    public string PlayerOne;
    public string PlayerTwo;
    public int TurnNumber;
    private GameDisplay _gameDisplay;

    public GameManager()
    {
        PlayerOne = "Player 1 [X]";
        PlayerTwo = "Player 2 [O]";
        TurnNumber = 0;
        _gameDisplay = new GameDisplay(); //initialize game display
    }

    public void ValidateMove() {
        _gameDisplay.RenderBoard();
        while(TurnNumber < 9){
            TurnNumber++;
            if (TurnNumber % 2 != 0) {
                Console.Write($"{PlayerOne} pick a square");
                int squareX = Console.ReadLine();
                // call a method that takes an int from player
                SetPlayerPiece(squareX, 'X');
            } else {
                Console.Write($"{PlayerTwo} pick a square");
                int squareO = Console.ReadLine();
                SetPlayerPiece(squareX, 'O');
            }
        }
        Console.WriteLine("Game Over");
    }

    public void SetPlayerPiece(int square, char playerSymbol) {
        if (square == 1) {

        }
        //player logic
        //call RenderBoard
        // ex: player chooses 1 --> char[0, 1] = playerX choice
    }

}

public class GameDisplay
{
    // 2D array for type char to represent the spaces on the game board.
    private char[,] _board;

    public GameDisplay()
    {
        // A 3 by 3 grid, numbered to represent user's available choices
        _board = new char[3, 3] 
        {                      
            { '1', '2', '3' }, // row index 0 element index {0, 1, 2}
            { '4', '5', '6' }, // row index 1 element index {0, 1, 2}
            { '7', '8', '9' }  // row index 2 element index {0, 1, 2}
        };
    }

    // Method to render the board
    public void RenderBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {_board[i, 0]} | {_board[i, 1]} | {_board[i, 2]} ");
            if (i < 2) Console.WriteLine("---+---+---");
        }
    }
}


// The console writeline checks the board at i, which to start is row/index 0, then it gets the  index 0 element in that row, then index 1 then index 2. If the row is less then 2, which at this point it is 0 then write out "---+---+---" below the first writeline. Because it's in a for loop of i < 3 it moves on to the next row (1) and does the same, then the next row 2... and because 2 is not < 2 it doesnt write out "---+---+---"
