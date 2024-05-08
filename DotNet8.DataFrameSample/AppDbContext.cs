using DotNet8.DataFrameSample.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.DataFrameSample;

public class AppDbContext : DbContext
{
    public string _connStr = "Server=.;Database=Pos;User ID=sa;Password=sasa@123;TrustServerCertificate=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connStr);
    }

    public DbSet<StateDataModel> State { get; set; }
}