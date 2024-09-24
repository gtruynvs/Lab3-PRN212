using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_PRN212
{
    public class Operator<T> where T : struct
    {
        public static T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da + db;
        }

        public static T Subtract(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da - db;
        }

        public static T Multiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da * db;
        }

        public static T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            if (db == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return da / db;
        }
    }
}
