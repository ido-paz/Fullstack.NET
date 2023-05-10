using MessagePack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopDAL;
using ShopWebAPI.DTO;
using ShopWebAPI.Utils;

namespace ShopWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        TokensManager _TokensManager;
        ShopDbContext _ShopDbContext;

        public UsersController(TokensManager tokensManager, ShopDbContext shopDbContext)
        {
            _TokensManager = tokensManager;
            _ShopDbContext = shopDbContext;
        }

        [HttpGet("{userID:int}")]
        public IActionResult Get(int userID)
        {
            var user = _ShopDbContext.Users.Find(userID);
            if (user == null)
                return NotFound();
            else
                //return Ok(new { user.UserId,user.UserName,user.RoleID});//anonymous class instance
                return Ok(new UserResponse(user));
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            var userInDb = _ShopDbContext.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (userInDb == null)
            {
                var ph = new PasswordHasher<User>();
                user.Password = ph.HashPassword(user, user.Password);
                user.RoleID = 2;// 1 - admin , 2 - user
                _ShopDbContext.Users.Add(user);
                _ShopDbContext.SaveChanges();
                LoginResponse lr = new LoginResponse()
                {
                    TokensData = GetNewTokensAndSave2DB(user),
                    UserResponse = new UserResponse(user)
                };
                return Created($"/users/{user.UserId}", lr);
            }
            else
            {
                return BadRequest("invalid user name ,allready exists");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var userInDb = _ShopDbContext.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (userInDb == null)
                return Unauthorized("invalid user name or password");
            else
            {
                var ph = new PasswordHasher<User>();
                var result = ph.VerifyHashedPassword(userInDb, userInDb.Password, user.Password);               
                if (userInDb == null || result == PasswordVerificationResult.Failed)
                    return Unauthorized("invalid user name or password");
                else
                {
                    LoginResponse lr = new LoginResponse()
                    {
                        TokensData = GetNewTokensAndSave2DB(userInDb),
                        UserResponse = new UserResponse(userInDb)
                    };
                    return Ok(lr);
                }
            }
        }

        [HttpPost("refreshToken")]
        public IActionResult RefreshToken(TokensData td)
        {
            var userInDb = _ShopDbContext.Users.FirstOrDefault(u => u.RefreshToken == td.RefreshToken && u.RefreshTokenExpires > DateTime.Now);
            if (userInDb == null)
            {
                return Unauthorized("token invalid");
            }
            else
            {
                LoginResponse lr = new LoginResponse()
                {
                    TokensData = GetNewTokensAndSave2DB(userInDb),
                    UserResponse = new UserResponse(userInDb)
                };
                return Ok(lr);
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


        TokensData GetNewTokensAndSave2DB(User user)
        {
            TokensData td = _TokensManager.GetInitializedTokens(user);
            //SaveCookiesToResponse(td);
            SaveRefreshToken2DB(user, td);
            return td;
        }

        void SaveCookiesToResponse(TokensData td)
        {
            Response.Cookies.Append("accessToken", td.AccessToken, new CookieOptions()
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = td.AccessTokenExpires
            });
            Response.Cookies.Append("refreshToken", td.RefreshToken, new CookieOptions()
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = td.RefreshTokenExpires
            });
        }

        void SaveRefreshToken2DB(User userInDb, TokensData td)
        {
            userInDb.RefreshToken = td.RefreshToken;
            userInDb.RefreshTokenExpires = td.RefreshTokenExpires;
            _ShopDbContext.SaveChanges();
        }
    }
}
