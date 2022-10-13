using System;


namespace CSE_210_HIGHLOW.Game
{

    public class Card

    {

        public int value;
        

        public Card()
        {
            
        }

        ///<summary>
        /// This function draws a random card from 1-13.
        ///</summary>
        public void Draw()
        {
            Random random = new Random();
            value = random.Next(1,14);
        }

        public bool IsLessThan(Card other)
        {
            return value < other.value;
        }

        public bool IsGreaterThan(Card other)
        {
            return value > other.value;
        }

        public string DisplayCard()
        {
            return $"{value}";
        }

        


    }   
}