using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionPoint.Security
{
    public class AuthorizationAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public string Permissions { get; set; } //Permission string to get from controller

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //get username
            var userName = context.HttpContext.User.Identity.Name;

            if (userName == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            } 

            //Validate if any permissions are passed when using attribute at controller or action level
            if (string.IsNullOrEmpty(Permissions))
            {
                //Validation cannot take place without any permissions so returning unauthorized
                context.Result = new UnauthorizedResult();
                return;
            }



            
            


            var requiredPermissions = Permissions.Split(","); //Multiple permissiosn can be received from controller, delimiter "," is used to get individual values
            foreach (var x in requiredPermissions)
            {

            }

            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
