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
       

        //public List<Spiller> GetAllSpillere()
        //{
        //    throw new NotImplementedException();
        //} 
        public void OnGet()
        {
            Spillere = _service.GetAllSpillere();
        }
    }
}
