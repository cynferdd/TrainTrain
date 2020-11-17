namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal Prix = 50m;

        public decimal? Réserver(Wagon wagon, int nbPlaces)
        {
            return
                wagon.Réserver(nbPlaces)
                    ? Prix
                    : (decimal?)null;
        }
    }
}