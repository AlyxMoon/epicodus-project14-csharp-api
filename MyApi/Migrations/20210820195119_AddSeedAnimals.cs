using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApi.Migrations
{
    public partial class AddSeedAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 14, "beagle", "cute and affectionate", "ames", "dog" },
                    { 73, 10, "siberian", "loves to run and play", "claire", "cat" },
                    { 72, 9, "norweigan", "loves to run and play", "frederick", "cat" },
                    { 71, 4, "siamese", "cute and affectionate", "olive", "cat" },
                    { 70, 10, "beagle", "cute and affectionate", "claire", "dog" },
                    { 69, 14, "shorthair", "cute and affectionate", "bob", "cat" },
                    { 68, 8, "husky", "cute and affectionate", "olive", "dog" },
                    { 67, 9, "lab", "needs a quiet home", "hailey", "dog" },
                    { 66, 3, "norweigan", "loves to run and play", "poppy", "cat" },
                    { 65, 16, "siberian", "loves to run and play", "bob", "cat" },
                    { 64, 9, "husky", "loves to run and play", "frederick", "dog" },
                    { 63, 9, "norweigan", "loves to run and play", "quin", "cat" },
                    { 62, 5, "lab", "needs a quiet home", "james", "dog" },
                    { 61, 14, "poodle", "has a strong personality", "ames", "dog" },
                    { 60, 5, "shorthair", "has a strong personality", "hailey", "cat" },
                    { 59, 6, "german shepherd", "has a strong personality", "whiskers", "dog" },
                    { 58, 16, "shorthair", "curious about the world", "eric", "cat" },
                    { 57, 6, "husky", "needs a quiet home", "henry", "dog" },
                    { 56, 6, "shorthair", "cute and affectionate", "ames", "cat" },
                    { 55, 9, "lab", "needs a quiet home", "ames", "dog" },
                    { 54, 9, "siberian", "has a strong personality", "poppy", "cat" },
                    { 53, 17, "beagle", "cute and affectionate", "bob", "dog" },
                    { 74, 11, "shorthair", "curious about the world", "ames", "cat" },
                    { 52, 2, "norweigan", "cute and affectionate", "james", "cat" },
                    { 75, 19, "beagle", "curious about the world", "whiskers", "dog" },
                    { 77, 18, "german shepherd", "cute and affectionate", "hailey", "dog" },
                    { 98, 18, "siberian", "curious about the world", "olive", "cat" },
                    { 97, 2, "siberian", "curious about the world", "claire", "cat" },
                    { 96, 14, "munchkin", "has a strong personality", "yarin", "cat" },
                    { 95, 11, "shorthair", "has a strong personality", "quin", "cat" },
                    { 94, 7, "munchkin", "has a strong personality", "thor", "cat" },
                    { 93, 7, "shorthair", "curious about the world", "frederick", "cat" },
                    { 92, 2, "shorthair", "cute and affectionate", "yarin", "cat" },
                    { 91, 7, "beagle", "needs a quiet home", "poppy", "dog" },
                    { 90, 13, "beagle", "cute and affectionate", "eric", "dog" },
                    { 89, 17, "siamese", "curious about the world", "eric", "cat" },
                    { 88, 6, "shorthair", "curious about the world", "yarin", "cat" },
                    { 87, 7, "siamese", "has a strong personality", "hal", "cat" },
                    { 86, 19, "poodle", "needs a quiet home", "poppy", "dog" },
                    { 85, 7, "munchkin", "curious about the world", "whiskers", "cat" },
                    { 84, 13, "husky", "needs a quiet home", "henry", "dog" },
                    { 83, 13, "siberian", "needs a quiet home", "henry", "cat" },
                    { 82, 8, "poodle", "cute and affectionate", "henry", "dog" },
                    { 81, 17, "beagle", "has a strong personality", "bob", "dog" },
                    { 80, 9, "norweigan", "has a strong personality", "frederick", "cat" },
                    { 79, 7, "siamese", "loves to run and play", "quin", "cat" },
                    { 78, 19, "german shepherd", "loves to run and play", "henry", "dog" },
                    { 76, 18, "german shepherd", "cute and affectionate", "james", "dog" },
                    { 51, 5, "lab", "curious about the world", "james", "dog" },
                    { 50, 6, "shorthair", "cute and affectionate", "poppy", "cat" },
                    { 49, 11, "beagle", "has a strong personality", "claire", "dog" },
                    { 22, 12, "norweigan", "curious about the world", "ames", "cat" },
                    { 21, 9, "norweigan", "loves to run and play", "frederick", "cat" },
                    { 20, 15, "shorthair", "has a strong personality", "eric", "cat" },
                    { 19, 17, "lab", "curious about the world", "whiskers", "dog" },
                    { 18, 8, "poodle", "loves to run and play", "bob", "dog" },
                    { 17, 1, "lab", "cute and affectionate", "frederick", "dog" },
                    { 16, 18, "siberian", "has a strong personality", "hailey", "cat" },
                    { 15, 3, "shorthair", "loves to run and play", "thor", "cat" },
                    { 14, 1, "siberian", "has a strong personality", "yarin", "cat" },
                    { 13, 4, "poodle", "cute and affectionate", "fig", "dog" },
                    { 12, 8, "shorthair", "curious about the world", "hailey", "cat" },
                    { 11, 19, "german shepherd", "has a strong personality", "hal", "dog" },
                    { 10, 17, "beagle", "loves to run and play", "thor", "dog" },
                    { 9, 2, "munchkin", "loves to run and play", "whiskers", "cat" },
                    { 8, 8, "shorthair", "loves to run and play", "hal", "cat" },
                    { 7, 11, "shorthair", "loves to run and play", "paws", "cat" },
                    { 6, 11, "siberian", "cute and affectionate", "eric", "cat" },
                    { 5, 16, "poodle", "has a strong personality", "bob", "dog" },
                    { 4, 6, "poodle", "needs a quiet home", "frederick", "dog" },
                    { 3, 7, "husky", "needs a quiet home", "poppy", "dog" },
                    { 2, 8, "norweigan", "loves to run and play", "quin", "cat" },
                    { 23, 14, "lab", "has a strong personality", "fig", "dog" },
                    { 24, 7, "german shepherd", "cute and affectionate", "thor", "dog" },
                    { 25, 2, "german shepherd", "cute and affectionate", "eric", "dog" },
                    { 26, 14, "munchkin", "loves to run and play", "poppy", "cat" },
                    { 48, 3, "siberian", "loves to run and play", "henry", "cat" },
                    { 47, 2, "shorthair", "has a strong personality", "hailey", "cat" },
                    { 46, 2, "beagle", "cute and affectionate", "henry", "dog" },
                    { 45, 13, "norweigan", "loves to run and play", "claire", "cat" },
                    { 44, 4, "shorthair", "cute and affectionate", "paws", "cat" },
                    { 43, 14, "lab", "has a strong personality", "eric", "dog" },
                    { 42, 5, "norweigan", "cute and affectionate", "frederick", "cat" },
                    { 41, 19, "husky", "loves to run and play", "yarin", "dog" },
                    { 40, 13, "siberian", "has a strong personality", "bob", "cat" },
                    { 39, 8, "shorthair", "loves to run and play", "james", "cat" },
                    { 99, 4, "beagle", "curious about the world", "paws", "dog" },
                    { 38, 5, "norweigan", "loves to run and play", "hal", "cat" },
                    { 36, 1, "beagle", "curious about the world", "quin", "dog" },
                    { 35, 3, "norweigan", "has a strong personality", "ames", "cat" },
                    { 34, 16, "munchkin", "needs a quiet home", "james", "cat" },
                    { 33, 12, "munchkin", "loves to run and play", "whiskers", "cat" },
                    { 32, 1, "norweigan", "has a strong personality", "henry", "cat" },
                    { 31, 3, "norweigan", "curious about the world", "yarin", "cat" },
                    { 30, 3, "munchkin", "has a strong personality", "pancake", "cat" },
                    { 29, 15, "norweigan", "cute and affectionate", "yarin", "cat" },
                    { 28, 13, "beagle", "loves to run and play", "thor", "dog" },
                    { 27, 9, "siberian", "loves to run and play", "yarin", "cat" },
                    { 37, 11, "shorthair", "has a strong personality", "ames", "cat" },
                    { 100, 13, "poodle", "cute and affectionate", "yarin", "dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 100);
        }
    }
}
