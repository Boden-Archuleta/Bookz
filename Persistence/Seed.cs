using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Books.Any()) return;

            var books = new List<Book>
            {
                new Book 
                {
                    Title = "Ender's Game",
                    Description = "Lorem ipsum, lorem ipsum, lorem ipsum",
                    Year = 1985
                },

                new Book 
                {
                    Title = "Cryptonomicon",
                    Description = "Lorem ipsum, lorem ipsum, lorem ipsum",
                    Year = 1999
                },

                new Book 
                {
                    Title = "Neuromancer",
                    Description = "Lorem ipsum, lorem ipsum, lorem ipsum",
                    Year = 1984
                },

                new Book 
                {
                    Title = "Snow Crash",
                    Description = "Lorem ipsum, lorem ipsum, lorem ipsum",
                    Year = 1993
                }
            };

            await context.AddRangeAsync(books);
            await context.SaveChangesAsync();
        }
    }
}