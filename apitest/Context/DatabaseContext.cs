using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Project> Projects { get; set; } // Represents the collection of projects
    public DbSet<Job> Jobs { get; set; } // Represents the collection of projects
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Set your connection string here (example with SQLite)
        optionsBuilder.UseMySQL("Server=localhost;Database=revamped_esprit_shop;Uid=root;Pwd=;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          // Project entity configuration
        modelBuilder.Entity<Project>()
            .Property(p => p.About)
            .HasMaxLength(500);

        // Job entity configuration
        modelBuilder.Entity<Job>()
            .Property(j => j.Email)
            .HasMaxLength(255);

        // Configure foreign key relationship
        modelBuilder.Entity<Job>()
            .HasOne(j => j.Project) // Job has one Project
            .WithMany() // Project can have many Jobs (optional)
            .HasForeignKey(j => j.ProjectID) // Foreign key
            .OnDelete(DeleteBehavior.NoAction); // Optional: Cascade delete 
    
}}
