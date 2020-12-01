namespace TrainTrain.Domain
{
    public class Voyageur
    {
        public Voyageur(string nom, string prenom, CarteReduction? carteReduction = null)
        {
            Nom = nom;
            Prenom = prenom;
            CarteReduction = carteReduction;
        }

        public string Nom { get; }
        public string Prenom { get; }
        public CarteReduction? CarteReduction { get; }
    }
}