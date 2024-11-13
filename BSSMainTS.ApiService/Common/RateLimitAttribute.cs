using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.RateLimiting;
namespace BSSMainTS.ApiService.Common;
public class RateLimitAttribute : ActionFilterAttribute
{
    private readonly string _policyName;

    public RateLimitAttribute(string policyName)
    {
        _policyName = policyName;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var rateLimiter = context.HttpContext.RequestServices.GetService<RateLimiter>();
        if (rateLimiter == null)
        {
            context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            return;
        }

        var lease = rateLimiter.AcquireAsync(1).Result; // Assuming 1 is the correct parameter for AcquireAsync

        if (!lease.IsAcquired)
        {
            context.Result = new StatusCodeResult(StatusCodes.Status429TooManyRequests);
        }
    }
}
