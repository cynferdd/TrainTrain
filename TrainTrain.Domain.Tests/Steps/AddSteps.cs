using TechTalk.SpecFlow;
using TrainTrain.Domain.Tests.Contexts;
using Xunit;

namespace TrainTrain.Domain.Tests.Steps
{
    [Binding]
    public class AddSteps
    {
        private readonly AddContext _context;

        public AddSteps(AddContext context) => 
            _context = context;

        [Given(@"un premier nombre (\d+)")]
        public void AddFirstNumber(int number) => 
            _context.First = number;

        [Given(@"un deuxième nombre (\d+)")]
        public void AddSecondNumber(int number) => 
            _context.Second = number;

        [When(@"on les additionne")]
        public void AddTwoNumbers() => 
            _context.Actual = _context.First + _context.Second;

        [Then(@"le résultat est (\d+)")]
        public void TheResultShouldBe(int expected) =>
            Assert.Equal(expected, _context.Actual);
    }
}