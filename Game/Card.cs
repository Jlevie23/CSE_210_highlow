using System;


namespace CSE_210_HIGHLOW.Game
{

    public class Card

    {

        public int value;
        

        public Card()
        {
            value = 1;
        }

        ///<summary>
        /// This function draws a random card from 1-13.
        ///</summary>
        public void Draw()
        {
            Random random = new Random();
            value = random.Next(1,14);
        }


    }   
}