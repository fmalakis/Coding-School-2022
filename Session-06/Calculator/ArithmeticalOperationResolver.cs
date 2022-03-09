using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ArithmeticalOperationResolver : Resolver
    {
        public override string Execute(ArithmeticalOperation arithmeticalOperation, string a, string b)
        {

            string result = string.Empty;

            switch (arithmeticalOperation)
            {
                case ArithmeticalOperation.Add:
                    result = handleAdd(a, b);
                    break;
                case ArithmeticalOperation.Subtract:
                    result = handleSubtract(a, b);
                    break;
                case ArithmeticalOperation.Multiply:
                    result = handleMultiply(a, b);
                    break;
                case ArithmeticalOperation.Divide:
                    result = handleDivision(a, b);
                    break;
                case ArithmeticalOperation.Power:
                    result = handlePow(a, b);
                    break;
                default:
                    break;
            }

            return result;

        }

        public override string Execute(ArithmeticalOperation arithmeticalOperation, string a)
        {
            return Convert.ToString(Math.Sqrt(Convert.ToDouble(a)));
        }

        private string handleAdd(string a, string b)
        {

            if (Int32.TryParse(a, out int result1) && Int32.TryParse(b, out int result2))
                return Convert.ToString(Operations.Add(result1, result2));

            return Convert.ToString(Operations.Add(Convert.ToDouble(a), Convert.ToDouble(b)));

        }

        private string handleSubtract(string a, string b)
        {

            if (Int32.TryParse(a, out int result1) && Int32.TryParse(b, out int result2))
                return Convert.ToString(Operations.Subtract(result1, result2));

            return Convert.ToString(Operations.Subtract(Convert.ToDouble(a), Convert.ToDouble(b)));

        }

        private string handleMultiply(string a, string b)
        {
            if (Int32.TryParse(a, out int result1) && Int32.TryParse(b,out int result2))
                return Convert.ToString(Operations.Multiply(result1, result2));

            return Convert.ToString(Operations.Multiply(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        private string handleDivision(string a, string b)
        {
            if (Int32.TryParse(a, out int result1) && Int32.TryParse(b, out int result2))
                return Convert.ToString(Operations.Divide(result1, result2));

            return Convert.ToString(Operations.Divide(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        private string handlePow(string a, string b)
        {
            if (Int32.TryParse(a, out int result1) && Int32.TryParse(b, out int result2))
                return Convert.ToString(Operations.Power(result1, result2));

            return Convert.ToString(Operations.Power(Convert.ToDouble(a), Convert.ToDouble(b)));
        }
    }
}
