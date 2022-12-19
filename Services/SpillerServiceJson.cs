using MatchMakerDBU.Model;
using System.Text.Json;


namespace MatchMakerDBU.Services
{
    public class SpillerServiceJson : ISpillerService
    {
        private const String fileDir = @"c:\DBU\MatchmakerJSon";
        private const String fileNameSpiller = fileDir + "spiller.json";
        //private const String fileNameModstander = fileDir + "modstander.json";



        private readonly List<Spiller> _spillere;
        //private readonly List<Spiller> _modstander;
        public SpillerServiceJson()
        {
            _spillere = ReadFromJson();
            //_modstander = ReadFromJson();
        }

        public void Add(Spiller spillere)
        {
            //if (spillere.Hold == 1)
            //{
            _spillere.Add(spillere);
            SaveToJson(fileNameSpiller, _spillere);
            //}
            //else if (spillere.Hold == 2)
            //{
            //    _modstander.Add(spillere);
            //    SaveToJson(fileNameModstander, _modstander);
            //}
        }

        public void DeleteSpiller(int nummer)
        {
            Spiller spiller = FindSpiller(nummer);
            //if (spiller.Hold == 1)
            //{
            _spillere.Remove(spiller);
            SaveToJson(fileNameSpiller, _spillere);
            //}
            //else if (spiller.Hold == 2)
            //{
            //    _modstander.Remove(spiller);
            //    SaveToJson(fileNameModstander, _modstander);
            //}
        }

        public void EditSpiller(Spiller newValues)
        {
            Spiller spiller = FindSpiller(newValues.Nummer);

            spiller.Nummer = newValues.Nummer;
            spiller.Name = newValues.Name;
            spiller.Rating = newValues.Rating;
            spiller.Type = newValues.Type;
            spiller.Hold = newValues.Hold;

            //if (spiller.Hold == 1)
            //{
            SaveToJson(fileNameSpiller, _spillere);
            //}
            //else if (spiller.Hold == 2)
            //{
            //    SaveToJson(fileNameModstander, _modstander);
            //}
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


        //private List<Spiller> ReadFromJson()
        //{
        //    if (File.Exists(fileNameSpiller))
        //    {
        //        using (var file = File.OpenText(fileNameSpiller))
        //        {
        //            String json = file.ReadToEnd();
        //            return JsonSerializer.Deserialize<List<Spiller>>(json);
        //        }
        //    }
        //    if (File.Exists(fileNameModstander))
        //    {
        //        using (var file = File.OpenText(fileNameModstander))
        //        {
        //            String json = file.ReadToEnd();
        //            return JsonSerializer.Deserialize<List<Spiller>>(json);
        //        }
        //    }

        //    return new List<Spiller>();
        //}

        private List<Spiller> ReadFromJson()
        {
            var result = new List<Spiller>();

            if (File.Exists(fileNameSpiller))
            {
                using (var file = File.OpenText(fileNameSpiller))
                {
                    String json = file.ReadToEnd();
                    result.AddRange(JsonSerializer.Deserialize<List<Spiller>>(json));
                }
            }

            //if (File.Exists(fileNameModstander))
            //{
            //    using (var file = File.OpenText(fileNameModstander))
            //    {
            //        String json = file.ReadToEnd();
            //        result.AddRange(JsonSerializer.Deserialize<List<Spiller>>(json));
            //    }
            //}

            return result;
        }


        private void SaveToJson(string fileName, List<Spiller> spillere)
        {
            String json = JsonSerializer.Serialize(spillere);
            File.WriteAllText(fileName, json);
        }


    }
}
