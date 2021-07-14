using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterestRateCalc.Api.Core
{
    public static class Constants
    {
        public static class AmountLimits
        {
            public const decimal DecisionMin = 2000;
            public const decimal DecisionMax = 69000;
        }

        public static List<(int Percent, decimal Min, decimal Max)> InterestRates = new List<(int Percent, decimal Min, decimal Max)>
        {
            (3, 0, 20000),
            (4, 20000, 39000),
            (5, 40000, 59000),
            (6, 60000, decimal.MaxValue)
        };
    }
}
