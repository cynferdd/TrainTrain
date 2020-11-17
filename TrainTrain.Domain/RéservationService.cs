namespace TrainTrain.Domain
{
    public class RéservationService
    {
        public decimal? Réserver(Wagon wagon, int nbPlaces)
        {
            return
                wagon.Réserver(nbPlaces)
                    ? 56756757657m
                    : (decimal?)null;
        }
    }
}