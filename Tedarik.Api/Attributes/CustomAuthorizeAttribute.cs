using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Tedarik.Core.Helpers.JwtHelper;

namespace Tedarik.Api.Attributes
{
    public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly List<string> _roles;

        public CustomAuthorizeAttribute(string roles)
        {
            // Rolleri parametre olarak alıyoruz, örnek: "100,101"
            _roles = roles.Split(',').ToList();
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            // JWT'den rolleri al
            var userRoles = JwtHelper.GetRolesFromJwt(token);

            // Eğer kullanıcının rolleri ile gerekli roller kesişmiyorsa yetkisiz hata döndür
            if (!_roles.Any(role => userRoles.Contains(role)))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
