using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OnlineBookStoreApp.Filters
{
    public class AdminFilter : IActionFilter
    {
        public void OnActionExecuting(
            ActionExecutingContext context)
        {
            var role =
                context.HttpContext.Session
                .GetString("Role");

            if (role != "Admin")
            {
                context.Result =
                    new ContentResult
                    {
                        Content =
                        "Only Admin Can Access This Page"
                    };
            }
        }

        public void OnActionExecuted(
            ActionExecutedContext context)
        {
        }
    }
}