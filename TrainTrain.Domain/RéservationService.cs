using System.Collections.Generic;
using System.Linq;

namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal SeuilDeReservation = 0.70m;
        private const decimal Prix = 50m;

        public decimal? Reserver(Train train, IReadOnlyCollection<Voyageur> voyageurs)
        {
            var nbPlaces = voyageurs.Count;
            var reservationValidee = train.Reserver(nbPlaces, SeuilDeReservation);

            var prixDeBase =
                voyageurs.Any(v => v.CarteReduction != null)
                    ? 25
                    : Prix;
            
            return
                reservationValidee
                ? prixDeBase * nbPlaces
                : (decimal?)null;
        }
    }
}