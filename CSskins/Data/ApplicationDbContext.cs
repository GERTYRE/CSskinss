using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CSskins.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        
 
        public DbSet<CSCase> CSCases { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            CSCase[] CSCases=new CSCase[5];
            CSCases[0] = new CSCase() { Id = 1, Name = "Vip Case", Price = 9999, CategoryId = 1 };
            CSCases[1] = new CSCase() { Id = 2, Name = "Basic Case", Price = 500, CategoryId = 2 };
            CSCases[2] = new CSCase() { Id = 3, Name = "Custom Case", Price = 150, CategoryId = 1 };
            CSCases[3] = new CSCase() { Id = 4, Name = "Epix Case", Price = 1250, CategoryId = 2 };
            Category[] Categories = new Category[2];
            Categories[0] = new Category() { Id = 1, Name = "Basic Packet Case" };
            Categories[1] = new Category() { Id = 2, Name = "Vip Packet Case" };
            builder.Entity<CSCase>().HasData(CSCases);
            builder.Entity<Category>().HasData(Categories);
        }
    }

    public class CSCase // Навігація
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CSCase> CSCases { get; set; } = new HashSet<CSCase>();
    }
}
