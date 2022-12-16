using MatchMakerDBU.Model;
using System.Text.Json;


namespace MatchMakerDBU.Services
{
    public class SpillerServiceJson : ISpillerService
    {
        private const String fileDir = @"c:\DBU\MatchmakerJSon";
        private const String fileName = fileDir + "spiller.json";




        private readonly List<Spiller> _spillere;

        public SpillerServiceJson()
        {
            _spillere = ReadFromJson();
        }

        public void  Add(Spiller spillere)
        {
            _spillere.Add(spillere);
            SaveToJson();
        }

        public void Delete(int nummer)
        {
            Spiller spiller = FindSpiller(nummer);
            _spillere.Remove(spiller);
            SaveToJson();
        }


        public void EditSpiller(Spiller newValues)
        {
            Spiller spiller = FindSpiller(newValues.Nummer);

            spiller.Nummer = newValues.Nummer;
            spiller.Name = newValues.Name;
            spiller.Rating = newValues.Rating;
            spiller.Type = newValues.Type;

            SaveToJson();
        }

        public Spiller FindSpiller(int nummer)
        {
            Spiller s = _spillere.Find(s => s.Nummer == nummer);
                if (s is not null)
            {
                return s;
            }
            throw new KeyNotFoundException();
        }

        public List<Spiller> GetAllSpillere()
        {
            return new List<Spiller>(_spillere);
        }


        private List<Spiller> ReadFromJson()
        {
            if(File.Exists(fileName))
            {
                using(var file = File.OpenText(fileName))
                {
                    String json = file.ReadToEnd();
                    return JsonSerializer.Deserialize<List<Spiller>>(json);
                }
            }

            return new List<Spiller>();
        }
            
        
        private void SaveToJson()
        {
            String json = JsonSerializer.Serialize(_spillere);
            File.WriteAllText(fileName, json); 
        }



    }
}
