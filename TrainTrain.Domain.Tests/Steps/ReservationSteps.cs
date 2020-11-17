using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class ReservationSteps
    {
        private readonly ReservationContext _context;

        public ReservationSteps(ReservationContext context) => 
            _context = context;

        [Given(@"un wagon qui contient (\d+) places ")]
        public void SettingTotalPlaces(int number) => 
            _context.TotalPlaces = number;

        [Given(@"aucune place n'est réservée")]
        public void SettingZeroOccupiedPlace() => 
            _context.OccupiedPlaces = 0;

        [When(@"on réserve (\d+) place")]
        public void PlaceReservation(int number){  
            _context.PlacesToReserve = number;
            _context.ReservationFaite = 
                new ReservationService().
                    Réserver(
                        _context.TotalPlaces, 
                        _context.OccupiedPlaces,
                        _context.PlacesToReserve);
        }

        [Then(@"la réservation est validée")]
        public void ReservationValidee() =>
            Assert.True(_context.ReservationFaite);
    }
}