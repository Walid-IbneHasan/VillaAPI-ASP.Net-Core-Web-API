using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Ocean view, Wi-Fi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beautiful villa by the beach.", "", "Beachfront Villa", 4, 300.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Mountain view, Fireplace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy villa nestled in the mountains.", "", "Mountain Villa", 5, 350.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "City view, Gym access", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A luxurious villa in the heart of the city.", "", "City Villa", 3, 400.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Garden, Outdoor pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A charming villa in the countryside.", "", "Countryside Villa", 6, 250.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Lake view, Canoe access", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene villa by the lake.", "", "Lake Villa", 2, 280.0, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Desert view, Air conditioning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A unique villa in the desert.", "", "Desert Villa", 4, 320.0, 650, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Forest view, Fireplace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A rustic villa surrounded by trees.", "", "Forest Villa", 4, 310.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Ocean view, Private beach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An exotic villa on a private island.", "", "Island Villa", 8, 500.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Jungle view, Outdoor shower", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An adventurous villa in the jungle.", "", "Jungle Villa", 3, 270.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Smart home features, Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A sleek, modern villa with all amenities.", "", "Modern Villa", 5, 450.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
