namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal Prix = 50m;

        public decimal? Reserver(Wagon wagon, int nbPlaces)
        {
            if (wagon.NbPlacesOccupees == 70m)
                return null;

            wagon.Reserver(nbPlaces);
            
            return Prix * nbPlaces;
        }
    }
}