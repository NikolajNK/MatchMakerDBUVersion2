using MatchMakerDBU.Model;
using MatchMakerDBU.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatchMakerDBU.Pages.Lommeregner
{
    public class DeleteSpillerModel : PageModel
    {

        private ISpillerService _service;


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
            _service.DeleteSpiller(nummer);

            return RedirectToPage("Index");
        }

        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }
    }
}
