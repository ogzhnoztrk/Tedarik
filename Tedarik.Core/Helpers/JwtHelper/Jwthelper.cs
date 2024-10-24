using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Core.Helpers.JwtHelper
{
    public class JwtHelper
    {
        public static List<string> GetRolesFromJwt(string jwtToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtTokenObj = handler.ReadJwtToken(jwtToken);
            var roleClaim = jwtTokenObj.Claims.FirstOrDefault(c => c.Type == "role")?.Value;

            if (roleClaim != null)
            {
                // Rolleri virgülle ayrılmış olarak parçala
                return roleClaim.Split(',').ToList();
            }

            return new List<string>();
        }
    }
}
