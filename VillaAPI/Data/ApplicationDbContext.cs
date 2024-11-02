using Microsoft.EntityFrameworkCore;
using VillaAPI.Model;

namespace VillaAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Beachfront Villa",
                    Details = "A beautiful villa by the beach.",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 600,
                    Amenity = "Ocean view, Wi-Fi",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Mountain Villa",
                    Details = "A cozy villa nestled in the mountains.",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 350,
                    Sqft = 700,
                    Amenity = "Mountain view, Fireplace",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 3,
                    Name = "City Villa",
                    Details = "A luxurious villa in the heart of the city.",
                    ImageUrl = "",
                    Occupancy = 3,
                    Rate = 400,
                    Sqft = 500,
                    Amenity = "City view, Gym access",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Countryside Villa",
                    Details = "A charming villa in the countryside.",
                    ImageUrl = "",
                    Occupancy = 6,
                    Rate = 250,
                    Sqft = 800,
                    Amenity = "Garden, Outdoor pool",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Lake Villa",
                    Details = "A serene villa by the lake.",
                    ImageUrl = "",
                    Occupancy = 2,
                    Rate = 280,
                    Sqft = 450,
                    Amenity = "Lake view, Canoe access",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 6,
                    Name = "Desert Villa",
                    Details = "A unique villa in the desert.",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 320,
                    Sqft = 650,
                    Amenity = "Desert view, Air conditioning",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 7,
                    Name = "Forest Villa",
                    Details = "A rustic villa surrounded by trees.",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 310,
                    Sqft = 600,
                    Amenity = "Forest view, Fireplace",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 8,
                    Name = "Island Villa",
                    Details = "An exotic villa on a private island.",
                    ImageUrl = "",
                    Occupancy = 8,
                    Rate = 500,
                    Sqft = 1000,
                    Amenity = "Ocean view, Private beach",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 9,
                    Name = "Jungle Villa",
                    Details = "An adventurous villa in the jungle.",
                    ImageUrl = "",
                    Occupancy = 3,
                    Rate = 270,
                    Sqft = 550,
                    Amenity = "Jungle view, Outdoor shower",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 10,
                    Name = "Modern Villa",
                    Details = "A sleek, modern villa with all amenities.",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 450,
                    Sqft = 700,
                    Amenity = "Smart home features, Pool",
                    CreatedDate = DateTime.Now,
                }
            );
        }


    }
}
