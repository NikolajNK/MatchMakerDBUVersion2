using MatchMakerDBU.Model;

namespace MatchMakerDBU.DK
{
    public class Danmark : Holdspiller
    {
        private List<Spiller> _spillere = new List<Spiller>()
        {
            new Spiller(1,"Kasper Schmeichel", 88, SpillerType.Målmand),
            new Spiller(16,"Oliver Christensen", 34, SpillerType.Målmand),
            new Spiller(22,"Frederik Rønnow", 24, SpillerType.Målmand),
            new Spiller(4,"Simon Kjær", 88, SpillerType.Forsvar ),
            new Spiller(2,"Joachim Andersen", 67, SpillerType.Forsvar),
            new Spiller(6,"Andreas Christensen", 76, SpillerType.Forsvar),
            new Spiller(3,"Victor Nelsson", 68, SpillerType.Forsvar),
            new Spiller(5,"Joakim Mæhle", 78, SpillerType.Forsvar),
            new Spiller(12,"Rasmus Nissen Kristensen", 67, SpillerType.Forsvar),
            new Spiller(18,"Daniel Wass", 67, SpillerType.Forsvar),
            new Spiller(17,"Jens Stryger Larsen", 67, SpillerType.Forsvar),
            new Spiller(26,"Alenxander Bah", 57, SpillerType.Forsvar),
            new Spiller(10,"Christian Eriksen", 89, SpillerType.Midtbane),
            new Spiller(8,"Thomas Delaney", 57, SpillerType.Midtbane),
            new Spiller(23,"Pierre-Emile Højbjerg", 56, SpillerType.Midtbane),
            new Spiller(7,"Mathias Jensen", 46, SpillerType.Midtbane),
            new Spiller(15,"Christian Nørgaard", 34, SpillerType.Midtbane),
            new Spiller(11,"Andreas Skov Olsen", 65, SpillerType.Angriber),
            new Spiller(9,"Marting Braithwaite", 12, SpillerType.Angriber),
            new Spiller(12,"Kasper Dolberg", 76, SpillerType.Angriber),
            new Spiller(14,"Mikkel Damsgaard", 78, SpillerType.Angriber),
            new Spiller(27,"Jesper Lindstrøm", 67, SpillerType.Angriber),
            new Spiller(19,"Jonas Wind", 34, SpillerType.Angriber),
            new Spiller(21,"Andreas Cornelius", 67, SpillerType.Angriber),
            new Spiller(20,"Yussuf Poulsen", 76, SpillerType.Angriber),
            new Spiller(24,"Robert Skov", 45, SpillerType.Angriber)

        };


           
        public List<Spiller> GetAllSpillere()
        {
            return new List<Spiller>(_spillere);
        }

        public void Add(Spiller spiller)
        {
            _spillere.Add(spiller);
        }
        
       public void DeleteSpiller(int nummer)
        {
            Spiller sletSpiller = FindSpiller(nummer);
            _spillere.Remove(sletSpiller);

        }

        public Spiller FindSpiller(int nummer)
        {
            foreach (Spiller s in _spillere)
            { 
                if (s.Nummer == nummer)
                {
                    return s;
                }
                    
            }

            throw new KeyNotFoundException();

        }


        public void EditSpiller(Spiller newValues)
        {
            Spiller editSpiller = FindSpiller(newValues.Nummer);
    
            editSpiller.Name = newValues.Name;
            editSpiller.Rating = newValues.Rating;
            editSpiller.Type = newValues.Type;

        }





    }
}
