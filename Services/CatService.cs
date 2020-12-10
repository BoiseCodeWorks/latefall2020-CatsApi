using System;
using System.Collections.Generic;
using LateFall2020CatsApi.DB;
using LateFall2020CatsApi.Models;

namespace LateFall2020CatsApi.Services
{
    public class CatService
    {
        public IEnumerable<Cat> GetCats()
        {
            return FakeDB.Cats;
        }

        public Cat Create(Cat newCat)
        {
            FakeDB.Cats.Add(newCat);
            return newCat;
        }

        public string Delort(int index)
        {
            FakeDB.Cats.RemoveAt(index);
            return "Cat Delorted!";
        }

        public Cat GetCat(int index)
        {
            return FakeDB.Cats[index];
        }
    }
}