using HRMS.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace HRMS.Api.Filters
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var requestID = Guid.NewGuid(); // error code
            var errorMsg = string.Format(CultureInfo.InvariantCulture, "{0}: Please use Reference ID {1} for support request.", "Oops... Something went wrong..!", requestID);
           
            //this.logger.LogException(actionExecutedContext.Exception, errorMsg);
            var apiResponse = new ApiResponse<string>(new ErrorModel(errorMsg));
            actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.OK);
            var jsonResponse = JsonConvert.SerializeObject(apiResponse);
            actionExecutedContext.Response.Content = new StringContent(jsonResponse);
            base.OnException(actionExecutedContext);
        }
    }
}