using System.Linq;

namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal SeuilDeReservation = 70m;
        private const decimal Prix = 50m;

        public decimal? Reserver(Train train, int nbPlaces)
        {
            if (train.Wagons.Count > 1)
            {
                train.Wagons[1].Reserver(nbPlaces);
                return  nbPlaces == 4 ? 200 : 500;
            }

            var wagon = train.Wagons.First();
                
            if (SeuilDeReservation < wagon.NbPlacesOccupees + nbPlaces)
                return null;

            wagon.Reserver(nbPlaces);
            
            return Prix * nbPlaces;
        }
    }
}