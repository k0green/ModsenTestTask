using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ModsenTestTask.Options;

namespace ModsenTestTask.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AccountController : ControllerBase
{
 
        [HttpPost("/token")]
        public async Task<IActionResult> Token()
        {
            var identity = GetIdentity();
            if (identity == null)
                return BadRequest(new { errorText = "Invalid username or password." });

            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
 
            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name
            };
 
            return Ok(response);
        }
 
        private ClaimsIdentity GetIdentity()
        {
                var claims = new List<Claim>();
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
        }
}