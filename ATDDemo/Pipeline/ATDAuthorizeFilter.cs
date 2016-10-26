using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ATDDemo.Pipeline
{
    public class ATDAuthorizeFilter : AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            Helper.Write("Authorization filter", actionContext.RequestContext.Principal);

            return true;
        }
    }
}