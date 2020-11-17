using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class ReservationSteps
    {
        private readonly ReservationService _service =
            new ReservationService();
        
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
        
        
        

        [When(@"on réserve (\d+) places?")]
        public void PlaceReservation(int nbPlaces)
        {
            var réservé =
                _service.Réserver(_context.Wagon, nbPlaces);
            _context.MontantActuel = réservé ?? 0;
            _context.ReservationFaite =
                réservé != null;
        }

        [Then(@"la réservation est validée")]
        public void ReservationValidee() =>
            Assert.True(_context.ReservationFaite);

        [Then(@"le prix est de (\d+) €")]
        public void VerifierPrix(decimal prix) =>
            Assert.Equal(prix, _context.MontantActuel);
        
        [Then(@"il y a (\d+) places? occupées? dans le wagon")]
        public void VerifierNbPlacesOccupées(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagon.NbPlacesOccupées);
    }
}