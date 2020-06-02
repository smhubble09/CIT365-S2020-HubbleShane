using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context) {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        //Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBooks { get; set; }


        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder) {

            //Sort by Book and Date
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Scripture> books = from b in _context.Scripture
                                          select b;
                switch (sortOrder) {
                case "name_desc":
                    books = books.OrderByDescending(b => b.Book);
                    break;
                case "Date":
                    books = books.OrderBy(b => b.TodayDate);
                    break;
                case "date_desc":
                    books = books.OrderByDescending(b => b.TodayDate);
                    break;
                default:
                    books = books.OrderBy(b => b.Book);
                    break;
            }
            

            //Search by Book
            IQueryable<string> bookQuery = from s in _context.Scripture
                                           orderby s.Book
                                           select s.Book;

            //Search by Keyword in Notes
            if (!string.IsNullOrEmpty(SearchString)) {
                books = books.Where(l => l.Notes.Contains(SearchString));
            }
            //Search by Book
            if (!string.IsNullOrEmpty(ScriptureBooks)) {
                books = books.Where(x => x.Book == ScriptureBooks);
            }
         
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await books.AsNoTracking().ToListAsync();
        }
    }
}
