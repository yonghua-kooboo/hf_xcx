using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace miniBG.Controllers
{
    public class FileUploadController : BaseController
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public FileUploadController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        protected async Task<string> Upload(IFormFile formFile)
        {
            var fileStream = formFile.OpenReadStream();
            var guid = Guid.NewGuid().ToString("N");
            var ext = Path.GetExtension(formFile.FileName);
            var webRootPath = GetFilePath(guid + ext);
            using (var stream = new FileStream(webRootPath, FileMode.Create, FileAccess.ReadWrite))
            {
                await formFile.CopyToAsync(stream);
            }

            return guid + ext;
        }

        protected string GetFilePath(string name)
        {
            var path = string.Empty;
            if (!string.IsNullOrEmpty(name))
            {
                path = hostingEnvironment.WebRootPath + "/uploads/" + name;
            }

            return path;
        }

        protected string ImgToBase64String(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var path = GetFilePath(name);
                    FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    byte[] arr = new byte[stream.Length];
                    stream.Position = 0;
                    stream.Read(arr, 0, (int)stream.Length);
                    stream.Close();

                    return "data:image/jpeg;base64," + Convert.ToBase64String(arr);
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
