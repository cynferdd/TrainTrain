using TechTalk.SpecFlow;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class AddSteps
    {
        private int _first;
        private int _second;
        private int _actual;

        [Given(@"un premier nombre (\d+)")]
        public void AddFirstNumber(int number) => 
            _first = number;

        [Given(@"un deuxième nombre (\d+)")]
        public void AddSecondNumber(int number) => 
            _second = number;

        [When(@"on les additionne")]
        public void AddTwoNumbers() => 
            _actual = _first + _second;

        [Then(@"le résultat est (\d+)")]
        public void TheResultShouldBe(int expected) =>
            Assert.Equal(expected, _actual);
    }
}