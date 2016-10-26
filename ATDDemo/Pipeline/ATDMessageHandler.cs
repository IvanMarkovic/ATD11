using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ATDDemo.Pipeline
{
    public class ATDMessageHandler : DelegatingHandler
    {
        protected async override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {

            Helper.Write("MessageHandler",null);

            //Inspect request

            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }
}