using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace W4A_GuessingGame
{
    public enum GuessResult
    {
        TooHigh,
        TooLow,
        JustRight
    }
    public class Game
    {
        private int _productPrice;
        public int Counter;
        public Game()
        {
            Random randomGenerator = new Random();
            _productPrice = randomGenerator.Next(0, 1001);
            Counter = 0;
        }

        public GuessResult CheckGuess(int userGuess)
        {
            Counter++;
            if (userGuess > _productPrice)
            
                return GuessResult.TooHigh;
            
            else if (userGuess < _productPrice)
            
                return GuessResult.TooLow;
            
            else
            
                return GuessResult.JustRight;

        }
    }
}
