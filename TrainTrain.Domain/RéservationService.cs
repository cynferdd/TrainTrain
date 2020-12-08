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
            var reservationValidee =
                voyage.Date.AddMonths(-1) <= dateReservation
                ? voyage.Train.ReserverLeWagonLeMoinsRempli(nbPlaces)
                : voyage.Train.ReserverLeWagonLePlusRempli(nbPlaces, SeuilDeReservation);

            var prixDeBase = Prix;
            if (voyage.Date.AddMonths(-1) <= dateReservation)
                prixDeBase = Prix + 10;
            else if (dateReservation < voyage.Date.AddMonths(-3).AddDays(1))
                prixDeBase = Prix - 20;
            
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