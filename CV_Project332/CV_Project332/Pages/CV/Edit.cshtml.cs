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
    public class EditModel : PageModel
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
        [BindProperty]
        public int X { get; set; }
        [BindProperty]
        public int Y { get; set; }

       



        public EditModel(DataClass dt,IFileUploadService fileUploadService, CV_Grade Grade, serverV serverV)
        {
          
            _dt = dt;
            _fileUploadService = fileUploadService;
            _Grade = Grade;
            _serverV = serverV;
        }


        public void OnGet(int id)
        {
            
             
            na = _dt.na;

            Random rand = new Random();
            X = rand.Next(1, 20);
            Y = rand.Next(20, 50);

            info = _dt.info.Where(u => u.Id==id).FirstOrDefault();
            filepath = info.Ipath;
        }
        public async Task<IActionResult> Onpost()
        {

            na = _dt.na;

            if (_serverV.vaild(X, Y, sum) == false)
            {
                ModelState.AddModelError(string.Empty, "Sum is wrong");

            }
            if (info.Email != EmailV)
            {
                ModelState.AddModelError(string.Empty, "Email are not equal");

            }
            Random rand = new Random();
            X = rand.Next(1, 20);
            Y = rand.Next(20, 50);

            if (fileP != null)
            {
                filepath = await _fileUploadService.UploadFileAsync(fileP);

                info.Ipath = filepath;
            }

            
            info.grade = _Grade.grade(info);
            if (ModelState.IsValid)
            {
                _dt.Update(info);
                _dt.SaveChanges();
                return RedirectToPage("CV_Views");
            }
            return Page();
        }
    }
}
