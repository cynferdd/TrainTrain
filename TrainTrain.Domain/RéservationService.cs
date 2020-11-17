namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal Prix = 50m;

        public decimal? Reserver(Wagon wagon, int nbPlaces)
        {
            return
                wagon.Reserver(nbPlaces)
                    ? Prix * nbPlaces
                    : (decimal?)null;
        }
    }
}