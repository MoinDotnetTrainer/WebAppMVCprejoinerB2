using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NuGet.Protocol;

namespace WebAppMVCprejoinerB2
{
    public class SetSession : ActionFilterAttribute
    {
        // here ill get the value of my session key 
        // if  the value in the key is null 
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var res = context.HttpContext.Session.GetString("UserEmail");
            if (res == null)
            {
                context.Result =
                  new RedirectToRouteResult(
                      new RouteValueDictionary {
                            {
                           "controller", "Action" },
                            { "action","Login" }
                      });
            }
        }
    }
}
