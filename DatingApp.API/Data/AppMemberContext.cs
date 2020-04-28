using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class AppMemberContext:DbContext
    {
        public AppMemberContext(DbContextOptions options):base (options){}

        public DbSet<AppMember> AppMembers{get;set;}


    }
}