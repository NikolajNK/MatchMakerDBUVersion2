using MatchMakerDBU.DK;
using MatchMakerDBU.Model;

namespace MatchMakerDBU.Services
{
    public class SpillerService : ISpillerService
    {
        private Danmark _spillere = new Danmark();

        public void Add(Spiller spiller)
        {
            _spillere.Add(spiller);
        }
        public void DeleteSpiller(int nummer)
        {
            _spillere.DeleteSpiller(nummer);
        }
        public void EditSpiller(Spiller newValues)
        {
            _spillere.EditSpiller(newValues);
        }
        public Spiller FindSpiller(int nummer)
        {
            return _spillere.FindSpiller(nummer);
        }
        public List<Spiller> GetAllSpillere()
        {
            return _spillere.GetAllSpillere();
        }


    }
}