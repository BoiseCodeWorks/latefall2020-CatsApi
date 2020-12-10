using System.Collections.Generic;
using LateFall2020CatsApi.Models;

namespace LateFall2020CatsApi.DB
{
    public static class FakeDB
    {
        public static List<Cat> Cats { get; set; } = new List<Cat>()
        {
            new Cat("Mr. Snibbley", "White and Grey and Chartreuse", 20390129),
            new Cat("Fluffy", "Purple", 9),
            new Cat("Jeffy", "Transparent Blue Ink", 3)
        };
    }
}