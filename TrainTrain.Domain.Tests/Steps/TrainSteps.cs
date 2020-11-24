using System.Collections.Generic;
using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class TrainSteps
    {
        private readonly ReservationService _service =
            new ReservationService();
        
        private readonly ReservationContext _context;

        public TrainSteps(ReservationContext context)
         => _context = context;

        [Given(@"un premier wagon occupé à (\d+)%")]
        public void SettingPremierWagon(int nbPlaces)
        {
            _context.Wagons = new List<Wagon>(){new Wagon(100)};
            _service.Reserver(_context.Wagons[0], nbPlaces);
        }
        
        [Given(@"un deuxième wagon vide")]
        public void SettingDeuxiemeWagonVide()
        {
            _context.Wagons.Add(new Wagon(100));
        }
            
        [Then(@"il y a (\d+) places? occupées? dans le premier wagon")]
        public void VerifierNbPlacesOccupéesPremierWagon(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagons[0].NbPlacesOccupees);
        
        [Then(@"il y a (\d+) places? occupées? dans le deuxième wagon")]
        public void VerifierNbPlacesOccupéesDeuxiemeWagon(int nbPlacesAttendues) =>
            Assert.Equal(nbPlacesAttendues, _context.Wagons[1].NbPlacesOccupees);
    }
}