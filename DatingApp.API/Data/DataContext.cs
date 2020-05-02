using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base (options){}
        public DbSet<AppMember> AppMembers{get;set;}
        public DbSet<User> Users{get;set;}

    }
}