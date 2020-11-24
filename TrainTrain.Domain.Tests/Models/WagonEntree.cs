namespace TrainTrain.Domain.Tests.Models
{
    public class WagonEntree
    {
        public int Numero { get; set; }

        public int NbPlaces { get; set; }

        public string Occupation { get; set; }

        public Wagon CreerWagon()
        {
            var wagon = new Wagon(this.NbPlaces);

            wagon.Reserver(int.Parse(Occupation[..^1]) * NbPlaces / 100 );

            return wagon;
        }
    }
}