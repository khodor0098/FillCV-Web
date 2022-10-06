using CV_Project332.Data;
using CV_Project332.Model;
using CV_Project332.Sevices;
using CV_Project332.wwwroot.FileUploadService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CV_Project332.Pages.CV
{
    public class DeleteModel : PageModel
    {
        private readonly DataClass _dt;

        private readonly CV_Grade _Grade;

        private readonly serverV _serverV;

        private readonly IFileUploadService _fileUploadService;

        public string filepath;

        public IEnumerable<Nationality> na { get; set; }

        [BindProperty]
        public informations info { get; set; }

        [BindProperty]
        public string EmailV { get; set; }

        [BindProperty]
        [NotMapped]
        public IFormFile fileP { get; set; }
        [BindProperty]
        public int sum { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

       



        public DeleteModel(DataClass dt,IFileUploadService fileUploadService, CV_Grade Grade, serverV serverV)
        {
          
            _dt = dt;
            _fileUploadService = fileUploadService;
            _Grade = Grade;
            _serverV = serverV;
        }


        public void OnGet(int id)
        {
            Random rand = new Random();
            X = rand.Next(1, 20);
            Y = rand.Next(20, 50);


            info = _dt.info.Where(u => u.Id==id).FirstOrDefault();
        }
        public async Task<IActionResult> Onpost()
        {

                      
           
            
            
                var infofromdb = _dt.info.Find(info.Id);
                if(infofromdb != null)
                {
                    _dt.info.Remove(infofromdb);
                    _dt.SaveChanges();
                return RedirectToPage("CV_Views");
            }
                
            
            return Page();
        }
    }
}
