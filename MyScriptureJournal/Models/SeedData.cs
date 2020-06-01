using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models {
    public class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>());

            //Look for any scriptures.
            if (context.Scripture.Any()) {
                return;
            }

            context.Scripture.AddRange(

                new Scripture {
                    Book = "3 Nephi",
                    Chapter = 11,
                    Verse = "33",
                    Notes = "",
                    TodayDate = DateTime.Parse("5/27/2020")
                },
                new Scripture {
                    Book = "1 Nephi",
                    Chapter = 3,
                    Verse = "7",
                    Notes = "Go and Do as the Lord commands.",
                    TodayDate = DateTime.Parse("5/27/2020")
                }
                );
            context.SaveChanges();
        }
    }
}
