using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Campain> Campain{ get; set; }

        public DbSet<Client> Client{ get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Issue> Issue { get; set; }
        public DbSet<Offer> Offer{ get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderSending> OrderSending{ get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }


    }
}
