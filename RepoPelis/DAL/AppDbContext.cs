using Microsoft.EntityFrameworkCore;
using RepoPelis.Model.Entities;

namespace RepoPelis.DAL
{
public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

public DbSet<User> Users { get; set; }
public DbSet<Movie> Movies { get; set; }
public DbSet<Genre> Genres { get; set; }
public DbSet<Actor> Actors { get; set; }
public DbSet<Rating> Ratings { get; set; }        
public DbSet<MovieActor> MovieActors { get; set; }
public DbSet<MovieGenre> MovieGenres { get; set; }
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
base.OnModelCreating(modelBuilder);
            
// Clave compuesta para MovieActor
modelBuilder.Entity<MovieActor>()
.HasKey(ma => new { ma.MovieId, ma.ActorId });

modelBuilder.Entity<MovieActor>()
.HasOne(ma => ma.Movie)
.WithMany(mr => mr.MovieActors)
.HasForeignKey(ma => ma.MovieId);

modelBuilder.Entity<MovieActor>()
.HasOne(ma => ma.Actor)
.WithMany(x => x.MovieActors)
.HasForeignKey(ma => ma.ActorId);



// Clave compuesta para MovieGenre
modelBuilder.Entity<MovieGenre>()
.HasKey(mg => new { mg.MovieId, mg.GenreId });

modelBuilder.Entity<MovieGenre>()
.HasOne(ma => ma.Movie)
.WithMany(t => t.MovieGenres)
.HasForeignKey(ma => ma.MovieId);

modelBuilder.Entity<MovieGenre>()
.HasOne(ma => ma.Genre)
.WithMany(g => g.MovieGenres)
.HasForeignKey(ma => ma.GenreId);



}


}
}
