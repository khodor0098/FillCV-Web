using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace CV_Project332.wwwroot.FileUploadService
{
    public class LocalFileUploadServic : IFileUploadService
    {
        private readonly IHostingEnvironment environment;

        public LocalFileUploadServic(IHostingEnvironment environment)
        {
            this.environment = environment;
        }
       

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\Images", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return file.FileName;
        }
    }
}
