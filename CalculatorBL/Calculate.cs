using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public static class Calculate
    {
        public static ResultData calculate(CalculateData calculateData)
        {
            return OperationFactory.CreateOperation(calculateData).Calculate(calculateData);
        }
    }
}
