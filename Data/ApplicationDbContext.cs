using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Learning_CRUD_ASP.NET_BASICS.Models;

namespace Learning_CRUD_ASP.NET_BASICS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Learning_CRUD_ASP.NET_BASICS.Models.Joke>? Joke { get; set; }
    }
}