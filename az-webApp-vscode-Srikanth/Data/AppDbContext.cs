using Microsoft.EntityFrameworkCore;

namespace az_webApp_vscode_Srikanth.Data
{
    public  class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }

       
    }
}

