using CV_Project332.Data;
using CV_Project332.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CV_Project332.Pages.CV
{
    public class CV_ViewsModel : PageModel
    {
        public readonly DataClass _db;

        public IEnumerable<informations> info { get; set; }

        public CV_ViewsModel(DataClass db)
        {
            _db = db;
        }

        public void OnGet()
        {
            info = _db.info;
        }
    }
}
