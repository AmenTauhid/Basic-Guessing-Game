using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace W4A_GuessingGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StartGame();
        }

        private Game _game;

        private void StartGame()
        {
            _game = new Game();
            messageLabel.Text = "Guess a number between 1 and 1000";
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                int userGuess = int.Parse(inputEntry.Text);
                GuessResult result= _game.CheckGuess(userGuess);
                if (result == GuessResult.TooHigh)
                {
                    resultLabel.Text = "Too high!";
                }
                else if (result == GuessResult.TooLow)
                {
                    resultLabel.Text = "Too low!";
                }
                else
                {
                    resultLabel.Text = $"That's the right answer! You tried {_game.Counter} times";
                }
            }
            catch (Exception exception)
            {
                resultLabel.Text = "Invalid Input";
            }
        }
    }
}
