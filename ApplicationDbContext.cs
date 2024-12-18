using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Trainer> Trainers{ get; set;}
    public DbSet<RentalPokemon> RentalPokemons{ get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=10.0.0.194;Database=POKEMON;Username=postgres;Password=postgres");
    }
}