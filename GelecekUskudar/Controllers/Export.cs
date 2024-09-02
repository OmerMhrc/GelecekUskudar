using GelecekUskudar.Helper;
using GelecekUskudar.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace GelecekUskudar.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class Export : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetExcelFiles()
        {
            byte[] data = await ExportExcelHelper.ExportToExcel(OgrenciRepository.OgrenciData());
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Exports", "export.xlsx");
            //System.IO.File.WriteAllBytes(filePath, data);
            // return Ok(filePath);
            return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ogrenciler.xlsx");
        }
    }
}