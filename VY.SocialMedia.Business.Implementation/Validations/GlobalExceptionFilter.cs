using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using VY.SocialMedia.Business.Implementation.Exceptions;

namespace VY.SocialMedia.Business.Implementation.Validations
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext exceptionContext)
        {
            if (exceptionContext.Exception.GetType() == typeof(BusinessException))
            {

                var exception = (BusinessException)exceptionContext.Exception;
                var validation = new
                {
                    Status = 400,
                    Title = "Bad request",
                    Detail = exception.Message,
                };

                var json = new
                {
                    errors = new[] { validation },
                };

                exceptionContext.Result = new BadRequestObjectResult(json);
                exceptionContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                exceptionContext.ExceptionHandled = true;
            }
        }
    }
}
