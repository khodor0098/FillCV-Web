using CV_Project332.Data;
using CV_Project332.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;


namespace CV_Project332.Pages.CV
{
    public class CV_SummaryModel : PageModel
    {
        private readonly DataClass _dt;
        public informations info { get; set; }

        public CV_SummaryModel(DataClass dt)
        {

            _dt = dt;
        }
        public void OnGet(int id)
        {

            info = _dt.info.Where(u => u.Id == id).FirstOrDefault();

        }

 

    }
}
