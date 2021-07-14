using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterestRateCalc.Api.Core.Dtos
{
    public class InterestRateDecisionDto
    {
        public string Decision { get; set; }
        public int? InterestRate { get; set; }
    }
}
