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

        public ReductionStep(ReservationContext context)
        {
            this._context = context;
        }
        [When(@"on réserve pour ces voyageurs :")]
        public void SettingVoyageurs(Table table)
        {
            _context.Voyageurs = 
                table.CreateSet<VoyageurEntree>()
                    .Select(v => v.CreerVoyageur())
                    .ToList();

            Reserver(_context.Voyageurs.ToList());
        }
        
        [When(@"on réserve pour ces voyageurs une semaine avant le départ :")]
        public void SettingVoyageursUneSemaine(Table table)
        {
            _context.Voyageurs = 
                table.CreateSet<VoyageurEntree>()
                    .Select(v => v.CreerVoyageur())
                    .ToList();

            Reserver(_context.Voyageurs.ToList());
        }
        
        [When(@"on réserve (\d+) places?")]
        public void PlaceReservation(int nbPlaces)
        {
            var voyageurs =
                Enumerable.Range(1, nbPlaces)
                    .Select(i => new Voyageur($"Nom{i}", $"Prénom{i}"))
                    .ToList();
            
            Reserver(voyageurs);
        }

        private void Reserver(IReadOnlyCollection<Voyageur> voyageurs)
        {
            var train = _context.CreerTrain();
            var reserve =
                _service.Reserver(train, voyageurs);
            _context.MontantActuel = reserve ?? 0;
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
            Assert.Equal(prix, _context.MontantActuel);
    }
}