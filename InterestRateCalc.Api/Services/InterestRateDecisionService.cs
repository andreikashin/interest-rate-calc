using InterestRateCalc.Api.Core;
using InterestRateCalc.Api.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterestRateCalc.Api.Services
{
    public class InterestRateDecisionService : IInterestRateDecisionService
    {
        public int GetPercent(decimal amount, int term, decimal existingCredit = 0)
        {
            var totalAmount =
                existingCredit + amount;

            foreach(var percentSet in Constants.InterestRates)
            {
                if (totalAmount >= percentSet.Min && totalAmount <= percentSet.Max)
                {
                    return percentSet.Percent;
                }
            }

            throw new Exception("wrong input");
        }

        public bool IsApproved(decimal amount)
        {
            return
                amount >= Constants.AmountLimits.DecisionMin &&
                amount <= Constants.AmountLimits.DecisionMax;
        }
    }
}
