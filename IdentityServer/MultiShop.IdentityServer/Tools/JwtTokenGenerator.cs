using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MultiShop.IdentityServer.Tools
{
	public class JwtTokenGenerator
	{
        public static TokenResponseViewModel GenerateToken(GetCheckAppUserViewModel getCheckAppUserViewModel)
		{
			var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(getCheckAppUserViewModel.Role))
                claims.Add(new Claim(ClaimTypes.Role,getCheckAppUserViewModel.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, getCheckAppUserViewModel.Id));

            if (!string.IsNullOrWhiteSpace(getCheckAppUserViewModel.UserName))
			claims.Add(new Claim("UserName",getCheckAppUserViewModel.UserName));

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
			var signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
			var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);
			JwtSecurityToken token = new JwtSecurityToken(issuer:JwtTokenDefaults.ValidIssuer,audience:JwtTokenDefaults.ValidAudience,claims:claims,notBefore:DateTime.UtcNow,expires:expireDate,signingCredentials:signingCredentials);
			JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

			return new TokenResponseViewModel(tokenHandler.WriteToken(token),expireDate);

		}
    }
}
