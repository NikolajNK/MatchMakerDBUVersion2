namespace MatchMakerDBU.Model
{
    public class Spiller : Holdspiller
    {


        public Spiller(int nummer, string name, double rating, SpillerType type)
        {
            Nummer = nummer;

            Name = name;

            Rating = rating;

            Type = type;
        }

        //public object SpillerType { get; internal set; }
        //public double Rating { get; internal set; }
        //public string Name { get; internal set; }
        //public int Nummer { get; internal set; }
    }

}
