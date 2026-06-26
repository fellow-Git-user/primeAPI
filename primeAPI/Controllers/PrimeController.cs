using Microsoft.AspNetCore.Mvc;
using primeAPI.Models;

namespace primeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrimeController : ControllerBase
    {
        [HttpPost]
        public ActionResult<PrimeResponse> Post(PrimeRequest request)
        {
            if (request is null)
            {
                return BadRequest();
            }

            var input = request.Input;
            var lowerPrime = FindNearestPrime(input, searchDown: true);
            var upperPrime = FindNearestPrime(input, searchDown: false);

            return Ok(new PrimeResponse
            {
                First = lowerPrime,
                Last = upperPrime
            });
        }

        private static int FindNearestPrime(int start, bool searchDown)
        {
            if (start < 2)
            {
                return searchDown ? 2 : 2;
            }

            var candidate = start;
            while (candidate >= 2)
            {
                if (IsPrime(candidate))
                {
                    return candidate;
                }

                candidate += searchDown ? -1 : 1;
            }

            return 2;
        }

        private static bool IsPrime(int value)
        {
            if (value < 2) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;

            var limit = (int)Math.Sqrt(value);
            for (var divisor = 3; divisor <= limit; divisor += 2)
            {
                if (value % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
