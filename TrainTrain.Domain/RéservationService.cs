using System;
using System.Collections.Generic;
using System.Linq;
using CSharpFunctionalExtensions;

namespace TrainTrain.Domain
{
    public class TauxOccupation : ValueObject
    {
        private readonly decimal valeur;
        
        public static TauxOccupation Min { get; } = new TauxOccupation(0);
        public static TauxOccupation Max { get; } = new TauxOccupation(1);
        
        public TauxOccupation(decimal valeur)
        {
        
            if (valeur < 0 || 1 < valeur)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.valeur = valeur;
        }

        public static decimal operator *(TauxOccupation taux, int valeur)
        {
            return valeur * taux.valeur;
        }

        public static decimal operator *(int valeur, TauxOccupation taux)
        {
            return valeur * taux.valeur;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return valeur;
        }
    }

    public class Prix : ValueObject
    {
        private readonly decimal valeur;

        public Prix(decimal valeur)
        {
            this.valeur = valeur;
        }

        public static Prix operator +(Prix prix1, Prix prix2) =>
            new Prix(prix1.valeur + prix2.valeur);
        
        public static Prix operator -(Prix prix1, Prix prix2) =>
            new Prix(prix1.valeur - prix2.valeur);
        
        public static Prix operator *(Prix prix1, decimal valeur) =>
            new Prix(prix1.valeur * valeur);
        
        public static Prix operator *(decimal valeur, Prix prix2) =>
            new Prix(valeur * prix2.valeur);
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return valeur;
        }
    }

    public class ReservationService
    {
        private static readonly TauxOccupation SeuilDeReservation = new TauxOccupation(0.70m);
        private static readonly Prix PrixDeBase = new Prix(50m);

        public Prix? Reserver(DateTime dateReservation, Voyage voyage, IReadOnlyCollection<Voyageur> voyageurs)
        {
            var nbPlaces = voyageurs.Count;
            var reservationValidee =
                voyage.Date.AddMonths(-1) <= dateReservation
                ? voyage.Train.ReserverSansSeuil(nbPlaces)
                : voyage.Train.ReserverLeWagonLePlusRempli(nbPlaces, SeuilDeReservation);
            

            return
                reservationValidee
                ? CalculPrixFinal(dateReservation, voyage, voyageurs)
                : null;
        }

        private static Prix CalculPrixFinal(DateTime dateReservation, Voyage voyage, IReadOnlyCollection<Voyageur> voyageurs)
        {
            var prixDeBase = PrixDeBase;
            if (voyage.Date.AddMonths(-1) <= dateReservation)
                prixDeBase = PrixDeBase + new Prix(10);
            else if (dateReservation < voyage.Date.AddMonths(-3).AddDays(1))
                prixDeBase = PrixDeBase - new Prix(20);

            return voyageurs
                    .Aggregate(new Prix(0), (acc, v) => 
                        acc + (prixDeBase - prixDeBase * Reduction(v.CarteReduction)));
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