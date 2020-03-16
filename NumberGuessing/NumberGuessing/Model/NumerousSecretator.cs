using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberGuessing.Model
{
    public class NumerousSecretator
    {
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public int NumberToGuess { get; set; }
        public int TipCounter { get; set; }
        public bool Guessed { get; set; }
        public int UserChoice { get; set; }
        public GameState LastGuessState { get; set; }
    }
}
