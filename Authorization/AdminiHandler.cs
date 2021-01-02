using System.Threading.Tasks;
using Check_Roles.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Check_Roles.Authorization
{
    public class AdminiHandler
                    : AuthorizationHandler<OperationAuthorizationRequirement, Module>
    {
        protected override Task HandleRequirementAsync(
                                              AuthorizationHandlerContext context,
                                    OperationAuthorizationRequirement requirement,
                                     Module resource)
        {
            
            if (requirement.Name != Constants.ReadOperationName 
                
                 )
            {
                return Task.CompletedTask;
            }


           
            if (context.User.IsInRole(Constants.AdminRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
