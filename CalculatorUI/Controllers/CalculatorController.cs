using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalculatorBL;
using Newtonsoft.Json;

namespace CalculatorUI.Controllers
{
    public class CalculatorController : ApiController
    {
        public string Post(CalculateData calculateData)
        {
            return JsonConvert.SerializeObject(Calculate.calculate(calculateData));
        }
    }
}
