using MatchMakerDBU.Model;
namespace MatchMakerDBU.Services
{
    public interface ISpillerService
    {
        public List<Spiller> GetAllSpillere();

        public void Add(Spiller spillere);

        public Spiller FindSpiller(int nummer);

        public void DeleteSpiller(int nummer);

        public void EditSpiller(Spiller newValues);


    }
}
