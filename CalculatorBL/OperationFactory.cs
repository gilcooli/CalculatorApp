using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public static class OperationFactory
    {
        public static ICalculate CreateOperation(CalculateData calculateData)
        {
            try
            {
                string objectToInstantiate = "CalculatorBL.Operations." + calculateData.Operation + ", CalculatorBL";

                var objectType = Type.GetType(objectToInstantiate);

                return (ICalculate)Activator.CreateInstance(objectType);
            }
            catch (Exception ex)
            {
                throw new Exception("operation is not valid");
            }
        }
    }
}
