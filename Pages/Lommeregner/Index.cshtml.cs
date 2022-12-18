using MatchMakerDBU.Model;
using MatchMakerDBU.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatchMakerDBU.Pages.Lommeregner
{
    public class IndexModel : PageModel
    {
        private ISpillerService _service;

        public IndexModel(ISpillerService service)
        {
            _service = service;
        }

        public List<Spiller> Spillere { get; set; }

        public void OnGet()
        {
            Spillere = _service.GetAllSpillere();

            //Nikolaj laver gennemsnsitsmetode
            double GennemsnitHold1 = UdregnGennemsnit(1);
            double GennemsnitHold2 = UdregnGennemsnit(2);

            ////  Hack
            //SpillerServiceJson service = new SpillerServiceJson();
            //foreach (var spiller in _service.GetAllSpillere())
            //{
            //    service.Add(spiller);
            //}
            //// slut hack



        }

        public double UdregnGennemsnit(int hold)
        {

            var players = Spillere.Where(s => s.Hold == hold);


            double sum = 0;
            foreach (var player in players)
            {
                sum += player.Rating;
            }


            double average = sum / players.Count();

            return average;
        }

    }
}
