using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TALWebAPI.Model;

namespace TALWebAPI.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("PremiumCalculation")]
    public class PremiumCalculationController : ControllerBase
    {      

        [HttpPost(Name = "CalculatePremium")]
        public int Premium([FromBody] Premium premiumValues)
        {
            return ((premiumValues.SumInsured * premiumValues.OccupationRatingFactor * premiumValues.Age) / 1000 * 12);
        }
    }
}