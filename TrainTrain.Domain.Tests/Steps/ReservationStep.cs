using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TrainTrain.Domain.Tests.Contexts;
using TrainTrain.Domain.Tests.Models;

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
        public void SettingWagons(Table table)
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
    }
}