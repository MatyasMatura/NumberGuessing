using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace NumberGuessing.Model
{
    public enum GameState
    {
        [Display(Name = "Je menší")]
        IsLess = -1,
        [Display(Name = "Je stejné")]
        IsEqual = 0,
        [Display(Name = "Je větší")]
        IsGreater = 1
    }
}
