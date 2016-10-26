using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATDDemo.Pipeline
{
    public class HttpModule :IHttpModule
    {
        public void Dispose()
        {
        }

        void context_BeginRequest(object sender,EventArgs args)
        {
            Helper.Write("HttpModule", HttpContext.Current.User);
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }
    }
}