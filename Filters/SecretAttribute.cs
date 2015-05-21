using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Filters
{
    public class SecretAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting( ActionExecutingContext filterContext )
        {
            if( filterContext.HttpContext.Request.RawUrl.Contains( "secret=toto" ) )
            {
                base.OnActionExecuting( filterContext );
            }
            else
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public override void OnActionExecuted( ActionExecutedContext filterContext )
        {
            base.OnActionExecuted( filterContext );
        }

        public override void OnResultExecuting( ResultExecutingContext filterContext )
        {
            base.OnResultExecuting( filterContext );
        }

        public override void OnResultExecuted( ResultExecutedContext filterContext )
        {
            base.OnResultExecuted( filterContext );
        }
    }
}