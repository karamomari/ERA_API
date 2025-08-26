using ERAAPI.Attributes;
using ERAAPI.DTO;
using ERAAPI.Services;
using System.Text.Json;

namespace ERAAPI.Middleware
{
    public class PrivilegeMiddleware
    {
        private readonly RequestDelegate _next;

        public PrivilegeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, PrivilegeService privilegeService)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint != null)
            {
                var privilegeAttr = endpoint.Metadata.GetMetadata<AuthorizePrivilegeAttribute>();
                if (privilegeAttr != null)
                {
                    var roleIdClaim = context.User.Claims.FirstOrDefault(c => c.Type == "RoleId");
                    if (roleIdClaim == null)
                    {
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        context.Response.ContentType = "application/json";

                        var response = new GeneralResponse<object>
                        {
                            Success = false,
                            Data = null,
                            Message = "RoleId missing in token"
                        };

                        await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                        return;
                    }

                    var roleId = decimal.Parse(roleIdClaim.Value);
                    var privileges = await privilegeService.GetPrivilegesByRoleAsync(roleId);

                    var allowed = privileges.Any(p =>
                      p.FormName == privilegeAttr.FormName &&
                      p.Action == privilegeAttr.Action
                     );


                    if (!allowed)
                    {
                        context.Response.StatusCode = StatusCodes.Status403Forbidden;
                        context.Response.ContentType = "application/json";

                        var response = new GeneralResponse<object>
                        {
                            Success = false,
                            Data = null,
                            Message = "You don't have permission for this action"
                        };

                        await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                        return;
                    }
                }
            }

            await _next(context);
        }
    }
}
