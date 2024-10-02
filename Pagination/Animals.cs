using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagination
{
    internal static class Animals
    {
        static IEnumerable<Animal> animals = new List<Animal>
        {
            new Animal { IsPet = true, Type = AnimalType.Cat, Color = AnimalColor.Black },
            new Animal { IsPet = true, Type = AnimalType.Cat, Color = AnimalColor.White },
            new Animal { IsPet = true, Type = AnimalType.Cat, Color = AnimalColor.Red },
            new Animal { IsPet = true, Type = AnimalType.Cat, Color = AnimalColor.Green },
            new Animal { IsPet = false, Type = AnimalType.Cat, Color = AnimalColor.Yellow },

            // Dogs
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.Black },
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.White },
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.Blue },
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.Green },
            new Animal { IsPet = false, Type = AnimalType.Dog, Color = AnimalColor.Red },

            // Birds
            new Animal { IsPet = false, Type = AnimalType.Bird, Color = AnimalColor.Black },
            new Animal { IsPet = true, Type = AnimalType.Bird, Color = AnimalColor.White },
            new Animal { IsPet = false, Type = AnimalType.Bird, Color = AnimalColor.Yellow },
            new Animal { IsPet = true, Type = AnimalType.Bird, Color = AnimalColor.Blue },
            new Animal { IsPet = false, Type = AnimalType.Bird, Color = AnimalColor.Green },

            // Fish
            new Animal { IsPet = false, Type = AnimalType.Fish, Color = AnimalColor.Blue },
            new Animal { IsPet = false, Type = AnimalType.Fish, Color = AnimalColor.White },
            new Animal { IsPet = false, Type = AnimalType.Fish, Color = AnimalColor.Red },
            new Animal { IsPet = false, Type = AnimalType.Fish, Color = AnimalColor.Green },
            new Animal { IsPet = false, Type = AnimalType.Fish, Color = AnimalColor.Yellow },

            // Mixed pets (variety of types and colors)
            new Animal { IsPet = true, Type = AnimalType.Cat, Color = AnimalColor.Yellow },
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.Black },
            new Animal { IsPet = true, Type = AnimalType.Bird, Color = AnimalColor.Red },
            new Animal { IsPet = true, Type = AnimalType.Fish, Color = AnimalColor.Black },

            // Additional Cats
            new Animal { IsPet = true, Type = AnimalType.Cat, Color = AnimalColor.Green },
            new Animal { IsPet = false, Type = AnimalType.Cat, Color = AnimalColor.Blue },
            new Animal { IsPet = false, Type = AnimalType.Cat, Color = AnimalColor.Red },

            // Additional Dogs
            new Animal { IsPet = false, Type = AnimalType.Dog, Color = AnimalColor.Green },
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.Yellow },
            new Animal { IsPet = false, Type = AnimalType.Dog, Color = AnimalColor.Blue },

            // Additional Birds
            new Animal { IsPet = true, Type = AnimalType.Bird, Color = AnimalColor.Black },
            new Animal { IsPet = false, Type = AnimalType.Bird, Color = AnimalColor.Red },
            new Animal { IsPet = true, Type = AnimalType.Bird, Color = AnimalColor.Yellow },

            // Additional Fish
            new Animal { IsPet = false, Type = AnimalType.Fish, Color = AnimalColor.Green },
            new Animal { IsPet = true, Type = AnimalType.Fish, Color = AnimalColor.Blue },
            new Animal { IsPet = true, Type = AnimalType.Fish, Color = AnimalColor.Black },

            // Varied Animals
            new Animal { IsPet = false, Type = AnimalType.None, Color = AnimalColor.Red },
            new Animal { IsPet = true, Type = AnimalType.None, Color = AnimalColor.Blue },
            new Animal { IsPet = true, Type = AnimalType.None, Color = AnimalColor.White },
            new Animal { IsPet = false, Type = AnimalType.None, Color = AnimalColor.Yellow },

            // Miscellaneous Pets
            new Animal { IsPet = true, Type = AnimalType.Dog, Color = AnimalColor.Blue },
            new Animal { IsPet = false, Type = AnimalType.Cat, Color = AnimalColor.Red }
        };

        public static PaginationResponse GetAnimals(PaginationRequest request)
        {
            PaginationResponse response = new PaginationResponse();
            response.TotalItems = animals.Count();
            response.PageSize = request.PageSize;

            response.TotalPages = response.TotalItems % response.PageSize == 0 ?
                response.TotalItems / response.PageSize : response.TotalItems / response.PageSize + 1;

            response.animals = animals.Skip((request.PageNumber - 1) * response.PageSize).Take(response.PageSize);

            return response;
        }
    }
}
