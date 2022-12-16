using MatchMakerDBU.DK;
using MatchMakerDBU.Model;
namespace MatchMakerDBU.Services
{
    public interface ISpillerService
    {

        public List<Spiller> GetAllSpillere();

        public void Add(Spiller spiller);

        public Spiller FindSpiller(int nummer);

        public void Delete(int nummer);

        public void EditSpiller(Spiller newValues);
    }
}
