using System.Threading.Tasks;
using Check_Roles.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace Check_Roles.Authorization
{
    public class DekanHandler :
        AuthorizationHandler<OperationAuthorizationRequirement, Module>
    {
        protected override Task
            HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement,
                                   Module resource)
        {
           

          

            // Managers can approve or reject.
            if (context.User.IsInRole(Constants.DekanRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
