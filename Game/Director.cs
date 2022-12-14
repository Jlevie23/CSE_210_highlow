using System;
using System.Collections.Generic;


namespace CSE_210_HIGHLOW.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        /// 
        /// 
        Card currentCard;
        bool _isPlaying = true;
        int _totalScore = 300;
        string guess = " ";

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>

        /// The code below creates 5 die, and adds it to the '_dice' list
        /// abstraction also can be real world object that we conceptualise in code (in this case dice)
        public Director()
        {
            currentCard = new Card();

            currentCard.Draw();

            Console.WriteLine($"Your Card is: {currentCard.value}");
            
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>

        /// StartGame() is a while loop; gets inputs, does updates, and does outputs
        /// prompt user to get input, GetInputs function asks user if they want to play
        /// _isPlaying is a 
        /// 
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Draw card? [y/n] ");
            string drawCard = Console.ReadLine();
            _isPlaying = (drawCard.ToLower() == "y");
        /// code below runs if statement as opposed to a while loop
            if (drawCard.ToLower() == "y")
            {
                _isPlaying = true;
            }
            else
            {
                _isPlaying = false;
            }

            Console.Write("Next card! [h/l] ");
            guess = Console.ReadLine();

            
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            Card nextCard = new Card();

            nextCard.Draw();

            Console.WriteLine($"Next card was: {nextCard.value}");
            if (nextCard.value < currentCard.value && guess == "l")
            {
                _totalScore += 100;
            }
            else if (nextCard.value > currentCard.value && guess == "h")
            {
                _totalScore += 100;
            }
            else 
            {
                _totalScore -= 75;
            }
/// I will need to create a roll method in Die
            currentCard = nextCard;
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }
/// need to create method in Die that is a int called ;value'
            
            

            Console.WriteLine($"You guessed: {guess}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
    }
}
