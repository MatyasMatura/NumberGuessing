using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumberGuessing.Model;


namespace NumberGuessing.Service
{
    public class NumerousSecretatorLogic
    {
        private readonly Random random;

        public NumerousSecretatorLogic(Random random)
        {
            this.random = random;
            userData = new NumerousSecretator();
        }

        public NumerousSecretator userData { get; set; }

        public bool Guess(int number)
        {
            userData.NumberToGuess = random.Next(userData.StartNumber, userData.EndNumber);
            while (userData.Guessed != true)
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
            return true;
        }
    }
}
