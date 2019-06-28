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
    public class BaseController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public BaseController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        protected async Task<string> Upload(IFormFile formFile)
        {
            var fileStream = formFile.OpenReadStream();
            var guid = Guid.NewGuid().ToString("N");
            var ext = Path.GetExtension(formFile.FileName);
            var webRootPath = GetFilePath(guid + ext);
            using (var stream = new FileStream(webRootPath, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }

            return webRootPath;
        }

        protected string GetFilePath(string name)
        {
            var path = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                path = hostingEnvironment.WebRootPath + "/uploads/" + name;
            }

            return path;
        }
    }
}
