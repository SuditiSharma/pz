using JwtTokenWebApi.Model.Data.Entities;
using JwtTokenWebApi.Model.Data;
using JwtTokenWebApi.Model.Logindto;
using JwtTokenWebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Model.Data.Entities;

namespace JwtTokenWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly MyAuthContext _myAuthContext;    
        public AccountController(IAccountService accountService,MyAuthContext myAuthContext)
        {
            _accountService = accountService;
            _myAuthContext= myAuthContext;  
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> GetLogin(LoginVal login)
        {
            try
            {
                var result = await _accountService.GetUserData(login);
                if (result == null)
                {
                    return ValidationProblem("Invalid Email or Password");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        

        [Route("RegisterUser")]
        [HttpPost]
        public IActionResult RegisterUser(RegisterVal user)
        {
            try
            {
                bool result =  _accountService.RegisterUser(user);
                if (result)
                return Ok("Register Success");
                else
                return Ok("Register Failed");
            }
            catch (Exception ex)
            {

                return Ok("Register Failed");
            }

        }
        [Route("ScoreEntry")]
        [HttpPost]
        public IActionResult ScoreEntry(UserScore score)
        {
            try
            {
                bool result = _accountService.enteruserscore(score);
                if (result)
                    return Ok(" Success");
                else
                    return Ok(" Failed");
            }
            catch (Exception ex)
            {

                return Ok(" Failed");
            }

        }

    }
}
