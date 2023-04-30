using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ShopDAL;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ShopWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IConfiguration _Configuration;
        ShopDbContext _ShopDbContext;

        public UsersController(IConfiguration configuration, ShopDbContext shopDbContext)
        {
            _Configuration = configuration;
            _ShopDbContext = shopDbContext;
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var userInDb = _ShopDbContext.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
            if (userInDb == null)
            {
                return Unauthorized("invalid user name or password");
            }
            else
            {
                return Ok(GetToken(user));
            }
        }

        [HttpGet("test1")]
        public string Test()
        {
            return "Hello World test1";
        }

        [HttpGet("test2")]
        [Authorize]
        public string Test2()
        {
            return "Hello World test2";
        }

        string GetToken(User user)
        {
            var issuer = _Configuration["Jwt:Issuer"];
            var audience = _Configuration["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes
            (_Configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString())
             }),
                Expires = DateTime.UtcNow.AddSeconds(30),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return tokenHandler.WriteToken(token);
        }

    }
}
