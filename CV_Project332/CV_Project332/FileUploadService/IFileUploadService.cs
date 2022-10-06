using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CV_Project332.wwwroot.FileUploadService
{
    public interface IFileUploadService
    {
          Task <string> UploadFileAsync(IFormFile file);
    }
}
