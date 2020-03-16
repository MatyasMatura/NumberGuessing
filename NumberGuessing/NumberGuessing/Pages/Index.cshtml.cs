using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NumberGuessing.Model;
using NumberGuessing.Service;

namespace NumberGuessing.Pages
{
    public class IndexModel : PageModel
    {
        private readonly NumerousSecretatorLogic _nmsLogic;

        public IndexModel(NumerousSecretatorLogic nmsLogic)
        {
            _nmsLogic = nmsLogic;
        }

        public string Message { get; set; }

        [BindProperty]
        public NumerousSecretator GameData { get; set; }

        [BindProperty]
        public int UserChoice { get; set; }

        // zahájení hry - začíná první kolo
        public void OnGet()
        {
            Message = "Začíná hra...pravidla už znáš";
            GameData = _nmsLogic.userData;
        }

        public void OnPost()
        {
            if (this.ModelState.IsValid)
            {
                _nmsLogic.userData = GameData;
                _nmsLogic.Guess(UserChoice);
            }
        }
    }
}
