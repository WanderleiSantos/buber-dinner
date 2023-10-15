using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var problemDetails = new ProblemDetails
        {
            Type = "",
            Title = "An error occurred while processing your request." ,
            Status = (int)HttpStatusCode.InternalServerError,
            
        };


        context.Result = new ObjectResult(problemDetails);
        context.ExceptionHandled = true;
    }
}