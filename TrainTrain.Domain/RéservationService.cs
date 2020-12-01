using System.Collections.Generic;

namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal SeuilDeReservation = 0.70m;
        private const decimal Prix = 50m;

        public decimal? Reserver(Train train, IReadOnlyCollection<Voyageur> voyageurs)
        {
            int nbPlaces = voyageurs.Count;
            var reservationValidee = train.Reserver(nbPlaces, SeuilDeReservation);

            return
                reservationValidee
                ? Prix * nbPlaces
                : (decimal?)null;
        }
    }
}