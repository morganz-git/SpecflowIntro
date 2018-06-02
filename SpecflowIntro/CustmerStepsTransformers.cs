using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    class CustmerStepsTransformers
    {
        //(\d+)用来匹配多个数字, here is pretty much important thing 
        [StepArgumentTransformation(@"(\d+) days from current time")]
        public DateTime DayAdderTranformer(int days )
        {
            return DateTime.Today.AddDays(days);
        }
    }
}
