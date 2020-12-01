namespace TrainTrain.Domain.Tests.Models
{
    public class VoyageurEntree
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string CarteReduction { get; set; }

        public Voyageur CreerVoyageur()
        {
            var carteDeReduction =
                CarteReduction switch
                {
                    "12-25" => Domain.CarteReduction.DouzeVingtCinq,
                    _ => (CarteReduction?)null
                };

            return new Voyageur(Nom, Prenom, carteDeReduction);
        }
    }
}