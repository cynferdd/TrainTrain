namespace TrainTrain.Domain.Tests.Models
{
    public class VoyageurEntree
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string CarteReduction { get; set; }

        public Voyageur CreerVoyageur()
        {
            return new Voyageur()
            {
                Nom =  this.Nom,
                Prenom = this.Prenom,
                CarteReduction = 
                    CarteReduction switch
                    {
                        "12-25" => Domain.CarteReduction.DouzeVingtCinq,
                        _ => null
                    }
            };
        }
    }
}