using Meus_produtos.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Meus_produtos.Application.Services
{
    public class TokenService
    {

        public static string GenerateToken(Usuario usuario) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Key);
            var tokenDescriptor = new SecurityTokenDescriptor { Subject = new ClaimsIdentity(new Claim[1] { 
                 new Claim(ClaimTypes.Email, usuario.Email.ToString())

            }),
                Expires = DateTime.UtcNow.AddHours(2),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
