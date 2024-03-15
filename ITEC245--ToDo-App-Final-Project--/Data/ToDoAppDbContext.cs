using ITEC245__ToDo_App_Final_Project__.Models;
using Microsoft.EntityFrameworkCore;

namespace ITEC245__ToDo_App_Final_Project__.Data;

public class ToDoAppDbContext: DbContext
{
    public DbSet<ITEC245__ToDo_App_Final_Project__.Models.Task> Tasks { get; set; }
    
    public DbSet<TaskReport> TaskReports { get; set; }
    
    public DbSet<TaskTeam> TaskTeams { get; set; }
    
    public DbSet<User> Users { get; set; }
    
    private IConfigurationRoot _configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ITEC245__ToDo_App_Final_Project__.Models.Task>().HasKey(t => t.TaskId);
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<TaskReport>().HasNoKey();
        modelBuilder.Entity<TaskTeam>().HasNoKey();
    }

    
}