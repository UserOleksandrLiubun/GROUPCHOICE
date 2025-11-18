using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
public class Contact
{
    [Key]
    public int Id { get; set; }
    public string UserId { get; set; }
    public string ContactUserId { get; set; }
    public bool IsAccepted { get; set; }
}
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<DBTask> Tasks { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}