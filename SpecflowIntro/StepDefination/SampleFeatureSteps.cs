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
            // EmployeeDetails details = table.CreateInstance<EmployeeDetails>();
            // Console.WriteLine(details.Name);
            //*******************important
//            var details = table.CreateSet<EmployeeDetails>();

            //so is you use assist dynamic,you no need to create employee class 
            var details = table.CreateDynamicSet();
            foreach (var variable in details)
            {
                Console.WriteLine("*********************");
                Console.WriteLine(variable.Name);
                Console.WriteLine(variable.Age);
                Console.WriteLine(variable.Phone);
                Console.WriteLine(variable.Email);
            }

        }

        [When(@"I fill all the mandatory details to form (.*),(.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsToFormKarthikAnd(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);

            ScenarioContext.Current["information"] = "step passed!";
            Console.WriteLine(ScenarioContext.Current["information"]);

            List<EmployeeDetails> employee = new List<EmployeeDetails>()
        {
            new EmployeeDetails()
            {
                Name = "morgan1",
                Age = 23,
                Email = "huahua@huahua",
                Phone = 221
                },
            new EmployeeDetails()
            {
                Name = "morgan2",
                Age = 23,
                Email = "huahua@huahua",
                Phone = 221
            },
            new EmployeeDetails()
            {
                Name = "morgan3",
                Age = 23,
                Email = "huahua@huahua",
                Phone = 221
            },

        };
            //save the value into scenario context
            ScenarioContext.Current.Add("key", employee);

            //get the value form scenario context
           var listEmp= ScenarioContext.Current.Get<List<EmployeeDetails>>("key");
            foreach (var emp in listEmp)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Phone);
            }


        }

    }
}
