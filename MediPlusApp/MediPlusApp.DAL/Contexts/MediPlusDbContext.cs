using MediPlusApp.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace MediPlusApp.DAL.Contexts;

public class MediPlusDbContext : DbContext
{
    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=MediPlusDB;User ID=SA; Password=reallyStrongPwd123;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True");
    }*/
    public MediPlusDbContext(DbContextOptions<MediPlusDbContext> options) : base(options) { }
    
    
    public DbSet<SliderItem> SliderItems { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
}