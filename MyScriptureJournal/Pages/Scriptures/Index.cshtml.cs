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

        public async Task OnGetAsync() {

            //Search by Book
            IQueryable<string> bookQuery = from s in _context.Scripture
                                           orderby s.Book
                                           select s.Book;
            //Search by Keyword in Notes
            var scriputres = from s in _context.Scripture
                             select s;
            //Search by Keyword in Notes
            if (!string.IsNullOrEmpty(SearchString)) {
                scriputres = scriputres.Where(l => l.Notes.Contains(SearchString));
            }
            //Search by Book
            if (!string.IsNullOrEmpty(ScriptureBooks)) {
                scriputres = scriputres.Where(x => x.Book == ScriptureBooks);
            }
         
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scriputres.ToListAsync();
        }
    }
}
