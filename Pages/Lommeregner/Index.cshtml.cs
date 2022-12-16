using Microsoft.AspNetCore.Mvc;
using MatchMakerDBU.DK;
using MatchMakerDBU.Model;
using MatchMakerDBU.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MatchMakerDBU.Services;

namespace MatchMakerDBU.Pages.Lommeregner
{
    public class IndexModel : PageModel
    {
        private ISpillerService _service;

        public IndexModel(ISpillerService service)
        {
            _service = service;
        }

        public List<Spiller> Spillere {get; set; }
       

        public void OnGet()
        {

            ////  Hack
            //SpillerServiceJson service = new SpillerServiceJson();
            //foreach (var spiller in _service.GetAllSpillere())
            //{
            //    service.Add(spiller);
            //}
            //// slut hack

            Spillere = _service.GetAllSpillere();
        }
    }
}
