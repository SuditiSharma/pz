using Domain.Model.Data.Entities;
using JwtTokenWebApi.Model.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace JwtTokenWebApi.Model.Data
{
    public class MyAuthContext : DbContext
    {
        public MyAuthContext(DbContextOptions<MyAuthContext> context) : base(context) { }
        public DbSet<User> User { get; set; }

        public DbSet<UserScore> UserScore{get; set; }

    }
}
