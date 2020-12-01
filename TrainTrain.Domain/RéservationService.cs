using System;
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

            var prix =
                voyageurs
                    .Sum(v => Prix - Prix * Reduction(v.CarteReduction));
            
            return
                reservationValidee
                ? prix
                : (decimal?)null;
        }

        private static decimal Reduction(CarteReduction? carteReduction) =>
            carteReduction switch
            {
                CarteReduction.DouzeVingtCinq => 0.5m,
                CarteReduction.Senior => 0.25m,
                CarteReduction.GrandVoyageur => 0.2m,
                _ => 0m
            };
    }
}