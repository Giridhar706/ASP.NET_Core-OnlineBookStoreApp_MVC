using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OnlineBookStoreApp.Filters
{
    public class ErrorFilter : IExceptionFilter
    {
        public void OnException(
            ExceptionContext context)
        {
            context.Result =
                new ViewResult
                {
                    ViewName = "Error"
                };

            context.ExceptionHandled = true;
        }
    }
}
