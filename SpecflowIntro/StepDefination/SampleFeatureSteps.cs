using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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
            if (result == 120)
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.Write("fail");
                throw new Exception("Fail");
            }
        }
        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            //the follow used to read record from table with single record
            EmployeeDetails details = table.CreateInstance<EmployeeDetails>();
            Console.WriteLine(details.Name);
        }



    }
}
