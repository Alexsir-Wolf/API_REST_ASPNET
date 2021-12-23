using Microsoft.EntityFrameworkCore;

namespace API_REST_ASPNET.Model.Context
{
    public class MySQLContext : DbContext
    {      
        public DbSet<Person> Persons { get; set; }
        public MySQLContext()
        {
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }

    }
}
