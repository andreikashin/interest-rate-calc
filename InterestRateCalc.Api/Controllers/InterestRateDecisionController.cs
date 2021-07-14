using InterestRateCalc.Api.Core.Dtos;
using InterestRateCalc.Api.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterestRateCalc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestRateDecisionController : ControllerBase
    {
        public IInterestRateDecisionService InterestRateDecisionService { get; set; }

        public InterestRateDecisionController(
            IInterestRateDecisionService interestRateDecisionService)
        {
            InterestRateDecisionService = interestRateDecisionService;
        }

        // GET: api/<InterestRateDecisionController>
        [HttpGet]
        public InterestRateDecisionDto Get([FromQuery] InputObjectDto input)
        {
            var response = new InterestRateDecisionDto();

            var amount = input.CreditAmount;
            var term = input.Term;
            var existing = input.ExistingCredit;
            var isApproved = InterestRateDecisionService.IsApproved(amount);
            var decision = isApproved
                    ? "Yes"
                    : "No";

            response.Decision = decision;

            if (!isApproved)
            {
                return response;
            }

            var percent = InterestRateDecisionService.GetPercent(amount, term, existing);
            response.InterestRate = percent;

            return response; 
        }
    }
}
