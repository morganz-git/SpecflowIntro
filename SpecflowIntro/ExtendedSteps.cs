using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails employeeDetails;

        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employeeDetails = emp;
        }

        [Then(@"I should the the same value from Extended steps")]
        public void ThenIShouldTheTheSameValueFromExtendedSteps()
        {
            Console.WriteLine(employeeDetails.Name);
            Console.WriteLine(employeeDetails.Age);
            Console.WriteLine(employeeDetails.Phone);
            Console.WriteLine(employeeDetails.Email);
            
        }

    }
}