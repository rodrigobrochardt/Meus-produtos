using Meus_produtos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meus_produtos.Application.ViewModels;

namespace Meus_produtos.Application.Services
{
    public class TokenService
    {

        public static string GenerateToken(UsuarioViewModel usuario) {
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
