using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class ValuesComparier
    {
        public static double GetMin(params double[] values)
        {
            double minValue = values[0];
            foreach (double value in values)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
            }

            return minValue;
        }
        public static double GetMax(double[] values)
        {
            double maxValue = values[0];
            foreach (double value in values)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }
    }
}
