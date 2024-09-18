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
       /* [HttpGet]
        public async Task<ActionResult> GetExcelFiles()
        {
            byte[] data = await ExportExcelHelper.ExportToExcel(OgrenciRepository.OgrenciData());
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Exports", "export.xlsx");
            //System.IO.File.WriteAllBytes(filePath, data);
            // return Ok(filePath);
            return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ogrenciler.xlsx");
        }*/

        [HttpGet("ilkokul")]
        public async Task<ActionResult> GetIlkokulExcel()
        {
            byte[] data = await ExportExcelHelper.ExportToExcel(OgrenciRepository.IlkOkulData());
            return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ilkokul_ogrenciler.xlsx");
        }

        [HttpGet("ortaokul")]
        public async Task<ActionResult> GetOrtaokulExcel()
        {
            byte[] data = await ExportExcelHelper.ExportToExcel(OgrenciRepository.OrtaOkulData());
            return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ortaokul_ogrenciler.xlsx");
        }

        [HttpGet("lise")]
        public async Task<ActionResult> GetLiseExcel()
        {
            byte[] data = await ExportExcelHelper.ExportToExcel(OgrenciRepository.LiseData());
            return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "lise_ogrenciler.xlsx");
        }
    }
}