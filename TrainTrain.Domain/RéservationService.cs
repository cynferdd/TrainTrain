using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainTrain.Domain
{
    public class ReservationService
    {
        private const decimal SeuilDeReservation = 0.70m;
        private const decimal Prix = 50m;

        public decimal? Reserver(DateTime dateReservation, Voyage voyage, IReadOnlyCollection<Voyageur> voyageurs)
        {
            var nbPlaces = voyageurs.Count;
            var reservationValidee = voyage.Train.Reserver(nbPlaces, SeuilDeReservation);

            var prixDeBase =
                voyage.Date.AddDays(-10) < dateReservation
                ? Prix + 10
                : Prix;
            
            var prixFinal =
                voyageurs
                    .Sum(v => prixDeBase - prixDeBase * Reduction(v.CarteReduction));
            
            return
                reservationValidee
                ? prixFinal
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