using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TrainTrain.Domain.Tests.Contexts;
using TrainTrain.Domain.Tests.Models;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class TrainSteps
    {
        private readonly ReservationContext _context;

        public TrainSteps(ReservationContext context)
         => _context = context;

        
        [Given(@"un train avec les wagons suivants :")]
        public void SettingWagons(Table table)
        {
            _context.Wagons = 
                table.CreateSet<WagonEntree>()
                    .OrderBy(w => w.Numero)
                    .Select(w => w.CreerWagon())
                    .ToList();
        }


        [Then(@"les wagons sont composés comme ceci :")]
        public void VerifierWagons(Table table)
        {
            var wagons = table.CreateSet<WagonSortie>();
            foreach (var wagon in wagons)
            {
                var realWagon = _context.Wagons[wagon.Numero -1];
                Assert.Equal(wagon.NbPlacesOccupees, realWagon.NbPlacesOccupees);
            }
        }
    }
}