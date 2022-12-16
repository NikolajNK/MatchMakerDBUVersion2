using MatchMakerDBU.Model;
using MatchMakerDBU.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatchMakerDBU.Pages.Lommeregner
{
    public class DeleteSpillerModel : PageModel
    {

        private ISpillerService _service;
        //private string position;



        //[BindProperty]
        //public string Position { get => position; set => position = value.ToLower(); }

        [BindProperty]
        public Spiller SletSpiller { get; set; }



        public DeleteSpillerModel(ISpillerService service)
        {
            _service = service;
        }


        public void OnGet(int nummer)
        {
            SletSpiller = _service.FindSpiller(nummer);
        }

        public IActionResult OnPostSlet(int nummer)
        {
            //switch (Position)
            //{
            //    case "forsvar": SletSpiller.Type = SpillerType.Forsvar; break;
            //    case "målmand": SletSpiller.Type = SpillerType.Målmand; break;
            //    case "midtbane": SletSpiller.Type = SpillerType.Midtbane; break;
            //    case "angriber": SletSpiller.Type = SpillerType.Angriber; break;
            //    default:
            //        break;
            //}
            _service.DeleteSpiller(nummer);

            return RedirectToPage("Index");
        }

        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }
    }
}
