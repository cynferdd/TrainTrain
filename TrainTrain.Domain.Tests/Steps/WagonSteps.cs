using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class WagonSteps
    {
        private readonly ReservationService _service =
            new ReservationService();
        
        private readonly ReservationContext _context;

        public WagonSteps(ReservationContext context) => 
            _context = context;

        [Given(@"un wagon qui contient (\d+) places")]
        public void SettingTotalPlaces(int nbPlaces) => 
            _context.Wagon = new Wagon(nbPlaces);

        [Given(@"aucune place n'est réservée")]
        public void SettingZeroOccupiedPlace()
        {
        }

        [Given(@"(\d+) places sont occupées")]
        public void SettingOccupiedPlaces(int nbPlaces)
        {
            _service.Reserver(_context.Wagon, nbPlaces);
        }

        [When(@"on réserve (\d+) places?")]
        public void PlaceReservation(int nbPlaces)
        {
            var reserve =
                _service.Reserver(_context.Wagon, nbPlaces);
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
        

        [Then(@"le prix est de (\d+) €")]
        public void VerifierPrix(decimal prix) =>
            Assert.Equal(prix, _context.MontantActuel);
        
        [Then(@"il y a (\d+) places? occupées? dans le wagon")]
        public void VerifierNbPlacesOccupées(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagon.NbPlacesOccupees);
    }
}