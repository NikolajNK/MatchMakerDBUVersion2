namespace MatchMakerDBU.Model

{


    public class Holdspiller
    {

        public Holdspiller()
        { }

        public Holdspiller(int nummer, string name, double rating, SpillerType type, int hold)
        {
            Nummer = nummer;

            Name = name;

            Rating = rating;

            Type = type;

            Hold = hold;

        }

        public int Nummer { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }

        public SpillerType Type { get; set; }

        public int Hold { get; set; }

        public virtual string GetInfo()
        {
            return "";
        }

        public override string ToString()
        {
            return $"{nameof(Nummer)} ={Nummer.ToString()},{nameof(Name)}={Name}, {nameof(Rating)} ={Rating.ToString()}, {nameof(Type)} ={Type.ToString()} {nameof(Hold)} ={Type.ToString()} ";
        }




    }
}
