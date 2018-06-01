using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
//表示这里面的所有用例都是输入user_login Feature的。同样可以用tag和scenario来作为关键字
//feature>tag>scenario
    [Scope(Feature = "User_Login")]
    public sealed class User_Login
    {
        [Given(@"I have open the application")]
        public void GivenIHaveOpenTheApplication()
        {
            Console.WriteLine("given user");
        }

        [Given(@"I login to application")]
        public void GivenILoginToApplication()
        {
            Console.WriteLine("given user");
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {
            Console.WriteLine("login user");
        }
    }
}