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

        [Given(@"un wagon qui contient (\d+) places")]
        public void SettingTotalPlaces(int nbPlaces) => 
            _context.Wagon = new Wagon(nbPlaces);

        [Given(@"aucune place n'est réservée")]
        public void SettingZeroOccupiedPlace()
        {
        }
        
        
        

        [When(@"on réserve (\d+) place")]
        public void PlaceReservation(int nbPlaces)
        {
            _context.ReservationFaite =
                _context.Wagon.Réserver(nbPlaces);
        }

        [Then(@"la réservation est validée")]
        public void ReservationValidee() =>
            Assert.True(_context.ReservationFaite);

        [Then(@"il y a (\d+) place occupée dans le wagon")]
        public void VerifierNbPlacesOccupées(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagon.NbPlacesOccupées);
    }
}