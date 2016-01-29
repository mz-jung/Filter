using Filter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    [SimpleMessage(Message = "A")]
    public class CustomerController: Controller
    {
        //[SimpleMessage(Message ="A", Order = 1)]
        //[SimpleMessage(Message = "B", Order = 2)]
        public string Index()
        {
            return "This is the Customer controller";
        }

        [CustomerOverrideActionFilters] //전역수준또는 컨트롤러 수준 액션필터 동작 X
        [SimpleMessage(Message = "B")]
        public string OtherAction() {
            return "This is the Other Action in the CUstomer controller";
        }
    }
}