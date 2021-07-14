using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterestRateCalc.Api.Core.Dtos
{
    public class InputObjectDto
    {
        public decimal CreditAmount { get; set; }
        public int Term { get; set; }
        public decimal ExistingCredit { get; set; }
    }
}
