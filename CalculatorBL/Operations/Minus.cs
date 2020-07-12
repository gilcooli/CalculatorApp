using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL.Operations
{
    class Minus : ICalculate
    {
        public ResultData Calculate(CalculateData calculateData)
        {
            return new ResultData() { 
                ResultValue = calculateData.FirstNumber - calculateData.SecondNumber 
            };
        }
    }
}
