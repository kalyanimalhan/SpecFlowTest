namespace SpecFlowProjectDemo.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int _number2;
        private int _number1;
        private int _result;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           _number1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           _number2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _number1 + _number2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
           result.Should().Be(_result);
        }
    }
}
