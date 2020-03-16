using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumberGuessing.Model;


namespace NumberGuessing.Service
{
    public class NumerousSecretatorLogic
    {
        private readonly Random random = new Random();

        public NumerousSecretatorLogic(Random random)
        {
            this.random = random;
            userData = new NumerousSecretator();
        }

        public NumerousSecretator userData { get; set; }

        public bool Guess(int number)
        {
            if (userData.TipCounter == 0)
            {
                userData.NumberToGuess = random.Next(userData.StartNumber, userData.EndNumber);
            }
            userData.UserChoice = number;
            userData.LastGuessState = GameState.None;
            if (userData.Guessed != true)
            {
                userData.TipCounter++;
                if (number > userData.NumberToGuess)
                {
                    userData.LastGuessState = GameState.IsGreater;
                    userData.Guessed = false;
                }
                if (number < userData.NumberToGuess)
                {
                    userData.LastGuessState = GameState.IsLess;
                    userData.Guessed = false;
                }
                if (number == userData.NumberToGuess)
                {
                    userData.LastGuessState = GameState.IsEqual;
                    userData.Guessed = true;
                }
                return false;
            }
            else
            {
                userData.TipCounter = 0;
                return true;
            }
        }
    }
}
