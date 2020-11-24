using System.Linq;

namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal SeuilDeReservation = 70m;
        private const decimal Prix = 50m;

        public decimal? Reserver(Train train, int nbPlaces)
        {
            var plusieursWagons = train.Wagons.Count > 1;
            var wagon =
                plusieursWagons
                    ? train.Wagons[1]
                    : train.Wagons[0];
            
            if (SeuilDeReservation < wagon.NbPlacesOccupees + nbPlaces)
                return null;

            wagon.Reserver(nbPlaces);

            if (plusieursWagons)
                return nbPlaces == 4 ? 200 : 500;

            return Prix * nbPlaces;
        }
    }
}