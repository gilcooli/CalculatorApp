using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public interface ICalculate
    {
        ResultData Calculate(CalculateData calculateData);
    }
}
