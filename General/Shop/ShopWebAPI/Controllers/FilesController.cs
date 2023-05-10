using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopWebAPI.DTO;
using ShopWebAPI.Utils;
using System.IO;

namespace ShopWebAPI.Controllers
{
    // install MimeMapping from Nuget

    [Route("[controller]")]
    [ApiController]
    //[Authorize]
    public class FilesController : ControllerBase
    {

        FilesManager _FilesManager;
        public FilesController(FilesManager filesManager)
        {
            _FilesManager = filesManager;
        }

        /// <summary>
        /// Returns a file by file name from the server.
        /// </summary>
        /// <param name="fileName">The name of the file to return.</param>
        /// <returns>A file content result or a not found result.</returns>
        [HttpGet("{fileName}")]
        public IActionResult GetFile(string fileName)
        {
            // Check if the file name is valid
            if (string.IsNullOrEmpty(fileName))
                return BadRequest("File name cannot be empty.");
            else
            {
                if (_FilesManager.Exists(fileName))
                {
                    HttpFile hf = _FilesManager.GetHttpFile(fileName);
                    return File(hf.FileContent, hf.ContentType, fileName);
                }
                else
                    return NotFound("File not found.");
            }
        }

        [HttpPost]
        //public IActionResult UploadFile([FromForm] IFormFile image)
        public IActionResult UploadFile()
        {
            if (Request.Form.Files.Count() > 0)
            {
                // Get the file from the request body
                var file = Request.Form.Files[0];
                // Get the file path from the app settings
                var filePath = "UsersFiles";// _configuration.GetValue<string>("FilePath");
                // Create the full path of the file
                var fullPath = filePath + "\\" + file.FileName;
                // Create the file on the server
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // Return a successful result
                return Created("/files/" + file.FileName, file.FileName);
            }
            else
            {
                return BadRequest("No file found in the request.");
            }
        }
    }
}
