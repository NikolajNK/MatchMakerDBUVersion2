namespace MatchMakerDBU.Model
{
    public interface IHoldspiller
    {
        int Nummer { get; set; }

        string Name { get; set; }

        double Rating { get; set; }

        SpillerType Type { get; set; }

        int Hold { get; set; }

        string GetInfo();

    }



}
