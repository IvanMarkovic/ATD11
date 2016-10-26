using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ATDDemo.Pipeline
{
    public class ATDAuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public async Task AuthenticateAsync(HttpAuthenticationContext context, System.Threading.CancellationToken cancellationToken)
        {
            Helper.Write("AuthenticationFilter", context.ActionContext.RequestContext.Principal);

            context.ActionContext.RequestContext.Principal = new GenericPrincipal (new GenericIdentity("John"), new string[] { "user" });
            Helper.Write("AuthenticationFilter", context.ActionContext.RequestContext.Principal);
        }

        public bool AllowMultiple
        {
            get { return false; }
        }


        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, System.Threading.CancellationToken cancellationToken)
        {
            
        }
    }
}