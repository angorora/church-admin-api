using Data.Models;
using Microsoft.EntityFrameworkCore;

public class ChurchAdminContext : DbContext{
   
   public DbSet<Congregant> Congregants { get; set; }
   public DbSet<FamilyFellowship> FamilyFellowships { get; set; }
   public DbSet<Leader> Leaders { get; set; }
   public DbSet<Ministry> Ministries { get; set; }
   public DbSet<Zone> Zones { get; set; }
}