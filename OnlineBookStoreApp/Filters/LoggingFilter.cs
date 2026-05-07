using Microsoft.AspNetCore.Mvc.Filters;

namespace OnlineBookStoreApp.Filters
{
    public class LoggingFilter : IActionFilter
    {
        public void OnActionExecuting(
            ActionExecutingContext context)
        {
            Console.WriteLine(
                $"Request received at {DateTime.Now}"
            );
        }

        public void OnActionExecuted(
            ActionExecutedContext context)
        {
        }
    }
}