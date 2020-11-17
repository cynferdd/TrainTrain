namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal SeuilDeReservation = 70m;
        private const decimal Prix = 50m;

        public decimal? Reserver(Wagon wagon, int nbPlaces)
        {
            if (SeuilDeReservation < wagon.NbPlacesOccupees + nbPlaces)
                return null;

            wagon.Reserver(nbPlaces);
            
            return Prix * nbPlaces;
        }
    }
}