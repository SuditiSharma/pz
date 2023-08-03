using Domain.Model.Data.Entities;

namespace JwtTokenWebApi.Model.Logindto
{
    public class LoginVal
    {
        
        public string Password { get; set; }

        public string Username { get; set; }
    }
    public class RegisterVal
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string Username { get; set; }
    }
    public class loginResult
    {
        public int UserId { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        public UserScore userScores { get; set; }

    }
}
