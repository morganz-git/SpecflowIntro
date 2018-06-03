using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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

        //modify the (.*) to (.* days from current time)
        //(.* days from current time)->匹配到CustmerStepsTransformers 中的   [StepArgumentTransformation(@"(\d+) days from current time")]
        [Then(@"I see user portal, the date is (.* days from current time)")]
        public void ThenISeeUserPortalTheDateIsDaysFromCurrentTime(DateTime currendaDateTime)
        {
            Console.WriteLine("parameters transformers!");
            Console.WriteLine(currendaDateTime);
        }

        [Then(@"I see the menus live")]
        public void ThenISeeTheMenusLive(Table table)
        {

            /*
             dynamic menus = table.CreateDynamicInstance();
            string menu = menus.Menu1;
            Console.WriteLine(menu);
            */

            //如果有多行数据

            /*
             * 这个方法也是可以的，直接用IEnumerable
             * IEnumerable<dynamic> mEnumerable = table.CreateDynamicSet();
             */
            //这里将IEnumerable 转换为 list，在进行使用；
            List<dynamic> menuList = table.CreateDynamicSet().ToList();
            dynamic menu = menuList.First();
            Console.WriteLine(menu.Menu2);
        }
    }
}