using MatchMakerDBU.Model;
using MatchMakerDBU.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatchMakerDBU.Pages.Lommeregner
{
    public class EditSpillerModel : PageModel
    {
        private ISpillerService _service;

        private string position;

        public EditSpillerModel(ISpillerService service)
        {
            _service = service;
        }


        [BindProperty]
        public int Nummer { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public double Rating { get; set; }

        [BindProperty]
        public string Position { get => position; set => position = value.ToLower(); }

        [BindProperty]
        public int Hold { get; set; }

        public void OnGet(int nummer)
        {
            Spiller editSpiller = _service.FindSpiller(nummer);

            Nummer = editSpiller.Nummer;
            Name = editSpiller.Name;
            Rating = editSpiller.Rating;
            Position = editSpiller.Type.ToString();
            Hold = editSpiller.Hold;

        }



        public IActionResult OnPostEdit()
        {
            Spiller editSpiller = new Spiller();

            if (!ModelState.IsValid)
            {
                return Page();
            }
            editSpiller.Nummer = Nummer;
            editSpiller.Name = Name;
            editSpiller.Rating = Rating;
            editSpiller.Hold = Hold;

            switch (Position)
            {
                case "forsvar": editSpiller.Type = SpillerType.Forsvar; break;
                case "målmand": editSpiller.Type = SpillerType.Målmand; break;
                case "midtbane": editSpiller.Type = SpillerType.Midtbane; break;
                case "angriber": editSpiller.Type = SpillerType.Angriber; break;
                default:
                    break;
            }


            _service.EditSpiller(editSpiller);

            return RedirectToPage("Index");

        }

        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }


    }
}
//spiller forsvinder ved edit hold = 0
//nummer komplikaton ved samme nummer