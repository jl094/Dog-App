namespace DogApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DogApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DogApp.Models.DogAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DogApp.Models.DogAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Dogs.AddOrUpdate(x => x.Id,
                new Dog() { Id = 1, Breed = "affenpinscher", SubBreed = "" },
                new Dog() { Id = 2, Breed = "african", SubBreed = "" },
                new Dog() { Id = 3, Breed = "airedale", SubBreed = "" },
                new Dog() { Id = 4, Breed = "akita", SubBreed = "" },
                new Dog() { Id = 5, Breed = "appenzeller", SubBreed = "" },
                new Dog() { Id = 6, Breed = "basenji", SubBreed = "" },
                new Dog() { Id = 7, Breed = "beagle", SubBreed = "" },
                new Dog() { Id = 8, Breed = "bluetick", SubBreed = "" },
                new Dog() { Id = 9, Breed = "borzoi", SubBreed = "" },
                new Dog() { Id = 10, Breed = "bouvier", SubBreed = "" },
                new Dog() { Id = 11, Breed = "boxer", SubBreed = "" },
                new Dog() { Id = 12, Breed = "brabancon", SubBreed = "" },
                new Dog() { Id = 13, Breed = "briard", SubBreed = "" },
                new Dog() { Id = 14, Breed = "bulldog", SubBreed = "boston" },
                new Dog() { Id = 15, Breed = "bulldog", SubBreed = "french" },
                new Dog() { Id = 16, Breed = "bullterrier", SubBreed = "staffordshire" },
                new Dog() { Id = 17, Breed = "cairn", SubBreed = "" },
                new Dog() { Id = 18, Breed = "chihuahua", SubBreed = "" },
                new Dog() { Id = 19, Breed = "chow", SubBreed = "" },
                new Dog() { Id = 20, Breed = "clumber", SubBreed = "" },
                new Dog() { Id = 21, Breed = "collie", SubBreed = "border" },
                new Dog() { Id = 22, Breed = "coonhound", SubBreed = "" },
                new Dog() { Id = 23, Breed = "corgi", SubBreed = "cardigan" },
                new Dog() { Id = 24, Breed = "dachshund", SubBreed = "" },
                new Dog() { Id = 25, Breed = "dane", SubBreed = "great" },
                new Dog() { Id = 26, Breed = "deerhound", SubBreed = "scottish" },
                new Dog() { Id = 27, Breed = "dhole", SubBreed = "" },
                new Dog() { Id = 28, Breed = "dingo", SubBreed = "" },
                new Dog() { Id = 29, Breed = "doberman", SubBreed = "" },
                new Dog() { Id = 30, Breed = "elkhound", SubBreed = "norwegian" },
                new Dog() { Id = 31, Breed = "entlebucher", SubBreed = "" },
                new Dog() { Id = 32, Breed = "eskimo", SubBreed = "" },
                new Dog() { Id = 33, Breed = "germanshepherd", SubBreed = "" },
                new Dog() { Id = 34, Breed = "greyhound", SubBreed = "italian" },
                new Dog() { Id = 35, Breed = "groenendael", SubBreed = "" },
                new Dog() { Id = 36, Breed = "hound", SubBreed = "Ibizan" },
                new Dog() { Id = 37, Breed = "hound", SubBreed = "afghan" },
                new Dog() { Id = 38, Breed = "hound", SubBreed = "basset" },
                new Dog() { Id = 39, Breed = "hound", SubBreed = "blood" },
                new Dog() { Id = 40, Breed = "hound", SubBreed = "english" },
                new Dog() { Id = 41, Breed = "hound", SubBreed = "walker" },
                new Dog() { Id = 42, Breed = "husky", SubBreed = "" },
                new Dog() { Id = 43, Breed = "keeshond", SubBreed = "" },
                new Dog() { Id = 44, Breed = "kelpie", SubBreed = "" },
                new Dog() { Id = 45, Breed = "komondor", SubBreed = "" },
                new Dog() { Id = 46, Breed = "kuvasz", SubBreed = "" },
                new Dog() { Id = 47, Breed = "labrador", SubBreed = "" },
                new Dog() { Id = 48, Breed = "leonberg", SubBreed = "" },
                new Dog() { Id = 49, Breed = "lhasa", SubBreed = "" },
                new Dog() { Id = 50, Breed = "malamute", SubBreed = "" },
                new Dog() { Id = 51, Breed = "malinois", SubBreed = "" },
                new Dog() { Id = 52, Breed = "maltese", SubBreed = "" },
                new Dog() { Id = 53, Breed = "mastiff", SubBreed = "bull" },
                new Dog() { Id = 54, Breed = "mastiff", SubBreed = "tibetan" },
                new Dog() { Id = 55, Breed = "mexicanhairless", SubBreed = "" },
                new Dog() { Id = 56, Breed = "mountain", SubBreed = "bernese" },
                new Dog() { Id = 57, Breed = "mountain", SubBreed = "swiss" },
                new Dog() { Id = 58, Breed = "newfoundland", SubBreed = "" },
                new Dog() { Id = 59, Breed = "otterhound", SubBreed = "" },
                new Dog() { Id = 60, Breed = "papillon", SubBreed = "" },
                new Dog() { Id = 61, Breed = "pekinese", SubBreed = "" },
                new Dog() { Id = 62, Breed = "pembroke", SubBreed = "" },
                new Dog() { Id = 63, Breed = "pinscher", SubBreed = "miniature" },
                new Dog() { Id = 64, Breed = "pointer", SubBreed = "german" },
                new Dog() { Id = 65, Breed = "pomeranian", SubBreed = "" },
                new Dog() { Id = 66, Breed = "poodle", SubBreed = "miniature" },
                new Dog() { Id = 67, Breed = "poodle", SubBreed = "standard" },
                new Dog() { Id = 68, Breed = "poodle", SubBreed = "toy" },
                new Dog() { Id = 69, Breed = "pug", SubBreed = "" },
                new Dog() { Id = 70, Breed = "pyrenees", SubBreed = "" },
                new Dog() { Id = 71, Breed = "redbone", SubBreed = "" },
                new Dog() { Id = 72, Breed = "retriever", SubBreed = "chesapeake" },
                new Dog() { Id = 73, Breed = "retriever", SubBreed = "curly" },
                new Dog() { Id = 74, Breed = "retriever", SubBreed = "flatcoated" },
                new Dog() { Id = 75, Breed = "retriever", SubBreed = "golden" },
                new Dog() { Id = 76, Breed = "ridgeback", SubBreed = "rhodesian" },
                new Dog() { Id = 77, Breed = "rottweiler", SubBreed = "" },
                new Dog() { Id = 78, Breed = "saluki", SubBreed = "" },
                new Dog() { Id = 79, Breed = "samoyed", SubBreed = "" },
                new Dog() { Id = 80, Breed = "schipperke", SubBreed = "" },
                new Dog() { Id = 81, Breed = "schnauzer", SubBreed = "giant" },
                new Dog() { Id = 82, Breed = "schnauzer", SubBreed = "miniature" },
                new Dog() { Id = 83, Breed = "setter", SubBreed = "english" },
                new Dog() { Id = 84, Breed = "setter", SubBreed = "gordon" },
                new Dog() { Id = 85, Breed = "setter", SubBreed = "irish" },
                new Dog() { Id = 86, Breed = "sheepdog", SubBreed = "english" },
                new Dog() { Id = 87, Breed = "sheepdog", SubBreed = "shetland" },
                new Dog() { Id = 88, Breed = "shiba", SubBreed = "" },
                new Dog() { Id = 89, Breed = "shihtzu", SubBreed = "" },
                new Dog() { Id = 90, Breed = "spaniel", SubBreed = "blenheim" },
                new Dog() { Id = 91, Breed = "spaniel", SubBreed = "brittany" },
                new Dog() { Id = 92, Breed = "spaniel", SubBreed = "cocker" },
                new Dog() { Id = 93, Breed = "spaniel", SubBreed = "irish" },
                new Dog() { Id = 94, Breed = "spaniel", SubBreed = "japanese" },
                new Dog() { Id = 95, Breed = "spaniel", SubBreed = "sussex" },
                new Dog() { Id = 96, Breed = "spaniel", SubBreed = "welsh" },
                new Dog() { Id = 97, Breed = "springer", SubBreed = "english" },
                new Dog() { Id = 98, Breed = "stbernard", SubBreed = "" },
                new Dog() { Id = 99, Breed = "terrier", SubBreed = "american" },
                new Dog() { Id = 100, Breed = "terrier", SubBreed = "australian" },
                new Dog() { Id = 101, Breed = "terrier", SubBreed = "bedlington" },
                new Dog() { Id = 102, Breed = "terrier", SubBreed = "border" },
                new Dog() { Id = 103, Breed = "terrier", SubBreed = "dandie" },
                new Dog() { Id = 104, Breed = "terrier", SubBreed = "fox" },
                new Dog() { Id = 105, Breed = "terrier", SubBreed = "irish" },
                new Dog() { Id = 106, Breed = "terrier", SubBreed = "kerryblue" },
                new Dog() { Id = 107, Breed = "terrier", SubBreed = "lakeland" },
                new Dog() { Id = 108, Breed = "terrier", SubBreed = "norfolk" },
                new Dog() { Id = 109, Breed = "terrier", SubBreed = "norwich" },
                new Dog() { Id = 110, Breed = "terrier", SubBreed = "patterdale" },
                new Dog() { Id = 111, Breed = "terrier", SubBreed = "scottish" },
                new Dog() { Id = 112, Breed = "terrier", SubBreed = "sealyham" },
                new Dog() { Id = 113, Breed = "terrier", SubBreed = "silky" },
                new Dog() { Id = 114, Breed = "terrier", SubBreed = "tibetan" },
                new Dog() { Id = 115, Breed = "terrier", SubBreed = "toy" },
                new Dog() { Id = 116, Breed = "terrier", SubBreed = "westhighland" },
                new Dog() { Id = 117, Breed = "terrier", SubBreed = "wheaten" },
                new Dog() { Id = 118, Breed = "terrier", SubBreed = "yorkshire" },
                new Dog() { Id = 119, Breed = "vizsla", SubBreed = "" },
                new Dog() { Id = 120, Breed = "weimaraner", SubBreed = "" },
                new Dog() { Id = 121, Breed = "whippet", SubBreed = "" },
                new Dog() { Id = 122, Breed = "wolfhound", SubBreed = "irish" }
                );
        }
    }
}
