using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ATDDemo.Pipeline
{
    [ATDAuthorizeFilter]
    [ATDAuthenticationFilter]
    [Authorize(Roles="admin")]
    public class TestController : ApiController
    {
        //[ATDAuthorizeFilter]
        public IHttpActionResult Get()
        {
            HttpCookie _userInfoCookies = HttpContext.Current.Request.Cookies["UserInfo"];

            Helper.Write("Controller", User);

            return Ok("Test Controller");
        }

        [AllowAnonymous]
        public IHttpActionResult GetAnon()
        {
            HttpCookie _userInfoCookies = HttpContext.Current.Request.Cookies["UserInfo"];

            Helper.Write("Controller", User);

            return Ok("Test Controller");
        }
    }
}
