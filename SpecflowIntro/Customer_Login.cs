using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
//    [Scope(Feature = "Customer_Login")]
//    [Scope(Scenario = "Login for customer portal")]
    [Scope(Tag = "customer_login")]

    public sealed class Customer_Login
    {
        [Given(@"I have open the application")]
        public void GivenIHaveOpenTheApplication()
        {
            Console.WriteLine("given customers");
        }

        [Given(@"I login to application")]
        public void GivenILoginToApplication()
        {
            Console.WriteLine("given customers");

        }

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {
            Console.WriteLine("login customers");
        }

    }
}
