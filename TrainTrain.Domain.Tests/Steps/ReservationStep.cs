using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TrainTrain.Domain.Tests.Contexts;
using TrainTrain.Domain.Tests.Models;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class ReductionStep
    {
        
        private readonly ReservationService _service =
            new ReservationService();
        private readonly ReservationContext _context;
        private readonly DateTime _dateVoyage = new DateTime(2020, 12, 01);

        public ReductionStep(ReservationContext context)
        {
            this._context = context;
        }
        [When(@"on réserve pour ces voyageurs :")]
        public void SettingVoyageurs(Table table)
        {
            ReserverVoyage(_dateVoyage.AddMonths(-2), table);
        }
        
        [When(@"on réserve pour ces voyageurs (.+) avant le départ :")]
        public void SettingVoyageursAvecDelai(string delai ,Table table)
        {
            var dateDelai = delai switch
            {
                "Une semaine" => _dateVoyage.AddDays(-7),
                "Un mois" => _dateVoyage.AddMonths(-1),
                "Deux jours" => _dateVoyage.AddDays(-2),
                "Deux semaines" => _dateVoyage.AddDays(-14),
                "Trois semaines" => _dateVoyage.AddDays(-21),
                _ => throw new NotSupportedException()
            };
           ReserverVoyage(dateDelai, table);
        }
        
        [When(@"on réserve pour ces voyageurs (.+) après le début de mise à disposition de la réservation :")]
        public void SettingVoyageursDansPremierMoisReservation(string delai, Table table)
        {
            var dateDelai = delai switch
            {
                "Une semaine" => _dateVoyage.AddMonths(-4).AddDays(7),
                "Un mois" => _dateVoyage.AddMonths(-4).AddMonths(1),
                "Deux jours" => _dateVoyage.AddMonths(-4).AddDays(2),
                "Deux semaines" => _dateVoyage.AddMonths(-4).AddDays(14),
                "Trois semaines" => _dateVoyage.AddMonths(-4).AddDays(21),
                "Un mois et Un jour" => _dateVoyage.AddMonths(-3).AddDays(1),
                "Deux mois" => _dateVoyage.AddMonths(-2),
                "Trois mois -1 jour" => _dateVoyage.AddMonths(-1).AddDays(-1),
                _ => throw new NotSupportedException()
            };
            ReserverVoyage(dateDelai, table);
        }

        private void ReserverVoyage(DateTime dateReservation, Table table)
        {
            _context.Voyageurs =
                table.CreateSet<VoyageurEntree>()
                    .Select(v => v.CreerVoyageur())
                    .ToList();
            
            Reserver(dateReservation, _context.Voyageurs.ToList());
        }

        [When(@"on réserve (\d+) places?")]
        public void PlaceReservation(int nbPlaces)
        {
            var voyageurs =
                Enumerable.Range(1, nbPlaces)
                    .Select(i => new Voyageur($"Nom{i}", $"Prénom{i}"))
                    .ToList();
            
            var dateReservation = _dateVoyage.AddMonths(-2);
            Reserver(dateReservation, voyageurs);
        }

        private void Reserver(DateTime dateReservation, IReadOnlyCollection<Voyageur> voyageurs)
        {
            var voyage =
                new Voyage(
                    _context.CreerTrain(),
                    _dateVoyage);
            
            var reserve = _service.Reserver(dateReservation, voyage, voyageurs);

            _context.MontantActuel = reserve ?? new Prix(0);
            _context.ReservationFaite =
                reserve != null;
        }
        
        
        [Then(@"la réservation est validée")]
        public void ReservationValidee() =>
            Assert.True(_context.ReservationFaite);
        
        [Then(@"la réservation est annulée")]
        public void ReservationAnnulée() =>
            Assert.False(_context.ReservationFaite);
        
        
        [Then(@"le prix est de (.+) €")]
        public void VerifierPrix(decimal prix) =>
            Assert.Equal(new Prix(prix), _context.MontantActuel);
    }
}