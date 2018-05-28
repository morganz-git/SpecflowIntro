using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowIntro.StepDefination
{
    [Binding]
    class SampleFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            Console.WriteLine(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           Console.WriteLine("Press the add button!");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result==120)
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.Write("fail");
                throw new Exception("Fail");
            }
        }

    }
}
