using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GymApp.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AK08ROO; database=Gym; integrated security=true;");

        }
        public DbSet<Member> members { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Manager> managers { get; set; }
        

    }
}
