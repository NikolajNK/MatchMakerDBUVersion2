using MatchMakerDBU.Model;
using MatchMakerDBU.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatchMakerDBU.Pages.Lommeregner
{
    public class CreateSpillerModel : PageModel
    {
        private ISpillerService _service;
        private string position;
        public string FejlBesked { get; set; }



        //properties
        [BindProperty]
        public Spiller Spiller { get; set; }


        [BindProperty]
        public string Position { get => position; set => position = value.ToLower(); }


        public CreateSpillerModel(ISpillerService service)
        {
            _service = service;
        }


        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            switch (Position)
            {
                case "forsvar": Spiller.Type = SpillerType.Forsvar; break;
                case "målmand": Spiller.Type = SpillerType.Målmand; break;
                case "midtbane": Spiller.Type = SpillerType.Midtbane; break;
                case "angriber": Spiller.Type = SpillerType.Angriber; break;
                default:
                    break;
            }

            var Spillere = _service.GetAllSpillere();

            if (Spillere.Any(s => s.Nummer == Spiller.Nummer && s.Hold == Spiller.Hold))
            {

                FejlBesked = "Du prøver at oprette en spiller med et nummer som allerede er optaget på holdet";
                return Page();
            }

            if (Spiller.Rating < 1 || Spiller.Rating > 99)
            {
                FejlBesked = "Rating må kun være fra 1 til 99";
                return Page();
            }

            _service.Add(Spiller);

            return RedirectToPage("Index");
        }

    }
}