using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterestRateCalc.Api.Core.ServiceInterfaces
{
    public interface IInterestRateDecisionService
    {
        public bool IsApproved(decimal amount);
        public int GetPercent(decimal amount, int term, decimal existingCredit);
    }
}
