//using MatchMakerDBU.Model;

//namespace MatchMakerDBU.DK
//{
//    public class Modstander : Holdspiller
//    {
//        private List<Spiller> _spillere = new List<Spiller>()
//        {

//        };

//        public List<Spiller> GetAllSpillere()
//        {
//            return new List<Spiller>(_spillere);
//        }

//        public void DeleteSpiller(int nummer)
//        {
//            Spiller sletSpiller = FindSpiller(nummer);
//            _spillere.Remove(sletSpiller);
//        }

//        public Spiller FindSpiller(int nummer)
//        {
//            foreach (Spiller s in _spillere)
//            {
//                if (s.Nummer == nummer)
//                {
//                    return s;
//                }
//            }

//            throw new KeyNotFoundException();
//        }

//        public void EditSpiller(Spiller newValues)
//        {
//            Spiller editSpiller = FindSpiller(newValues.Nummer);

//            editSpiller.Name = newValues.Name;
//            editSpiller.Rating = newValues.Rating;
//            editSpiller.Type = newValues.Type;

//        }
//    }
//}