using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class TrainSteps
    {
        private readonly ReservationContext _context;

        public TrainSteps(ReservationContext context)
         => _context = context;

        [Given(@"un premier wagon occupé à (\d+)%")]
        public void SettingPremierWagon(int nbPlaces)
        {
            var wagon = new Wagon(100);
            wagon.Reserver(nbPlaces);
            
            if( _context.Wagons.Count < 1)
                _context.Wagons.Add(wagon);
            else
                _context.Wagons[0] = wagon;
        }
        
        [Given(@"un deuxième wagon vide")]
        public void SettingDeuxiemeWagonVide()
        {
            var wagon = new Wagon(100);
            
            if( _context.Wagons.Count < 2)
                _context.Wagons.Add(wagon);
            else
                _context.Wagons[1] = wagon;
        }
        
        [Given(@"un deuxième wagon occupé à (\d+)%")]
        public void SettingDeuxièmeWagon(int nbPlaces)
        {
            var wagon = new Wagon(100);
            wagon.Reserver(nbPlaces);
            
            if( _context.Wagons.Count < 2)
                _context.Wagons.Add(wagon);
            else
                _context.Wagons[1] = wagon;
        }
        
        [Given(@"un troisième wagon occupé à (\d+)%")]
        public void SettingTroisièmeWagon(int nbPlaces)
        {
            var wagon = new Wagon(100);
            wagon.Reserver(nbPlaces);
            
            if( _context.Wagons.Count < 3)
                _context.Wagons.Add(wagon);
            else
                _context.Wagons[2] = wagon;
        }
            
        [Then(@"il y a (\d+) places? occupées? dans le premier wagon")]
        public void VerifierNbPlacesOccupéesPremierWagon(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagons[0].NbPlacesOccupees);
        
        [Then(@"il y a (\d+) places? occupées? dans le deuxième wagon")]
        public void VerifierNbPlacesOccupéesDeuxiemeWagon(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagons[1].NbPlacesOccupees);
        
        [Then(@"il y a (\d+) places? occupées? dans le troisième wagon")]
        public void VerifierNbPlacesOccupéesTroisiemeWagon(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagons[2].NbPlacesOccupees);
    }
}