using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL.Operations
{
    class Divide : ICalculate
    {
        public ResultData Calculate(CalculateData calculateData)
        {
            if (calculateData.SecondNumber == 0) throw new ArgumentException("Can not divide by zero");

            return new ResultData() { 
                ResultValue = calculateData.FirstNumber / calculateData.SecondNumber 
            };
        }
    }
}
