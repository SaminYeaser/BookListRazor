using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public createModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public book book { get; set; }
        public void OnGet()
        {

        }
    }
}
