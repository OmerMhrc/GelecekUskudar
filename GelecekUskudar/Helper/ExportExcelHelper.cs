using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using GelecekUskudar.Models;
using System.Threading.Tasks;
using OfficeOpenXml.Style;


namespace GelecekUskudar.Helper
{
    public class ExportExcelHelper
    {
        public static async Task<byte[]> ExportToExcel(List<Ogrenci> ogrenciler /*, string filePath*/)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Öğrenciler");

                // Başlık satırını yazdır
                worksheet.Cells["A1"].Value = "İsim";
                worksheet.Cells["B1"].Value = "Soyisim";
                worksheet.Cells["C1"].Value = "Ögrenim Durumu";
                worksheet.Cells["D1"].Value = "Ögrenci Notu";
                worksheet.Cells["E1"].Value = "Ögretmen Yorumu";

                worksheet.Column(3).Width = 20; // Öğrenim Durumu sütunu
                worksheet.Column(4).Width = 15; // Öğrenci Notu sütunu
                worksheet.Column(5).Width = 40;

                // Verileri yazdır
                int rowIndex = 2;
                foreach (var ogrenci in ogrenciler)
                {
                    worksheet.Cells[rowIndex, 1].Value = ogrenci.Name;
                    worksheet.Cells[rowIndex, 2].Value = ogrenci.Surname;

                    if(ogrenci.OgrenimDurumu == 1)
                    {
                        worksheet.Cells[rowIndex, 3].Value = "İlkokul";
                    }
                    else if (ogrenci.OgrenimDurumu == 2)
                    {
                        worksheet.Cells[rowIndex, 3].Value = "Ortakokul";
                    }
                    else if (ogrenci.OgrenimDurumu == 3)
                    {
                        worksheet.Cells[rowIndex, 3].Value = "Lise";
                    }
                    
                    worksheet.Cells[rowIndex, 4].Value = ogrenci.OgrenciNotu;
                    worksheet.Cells[rowIndex, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    worksheet.Cells[rowIndex, 5].Value = ogrenci.OgretmenYorumu;
                    rowIndex++;
                }
                // Excel dosyasını kaydet
                //FileInfo excelFile = new FileInfo(filePath);
                //package.SaveAs(excelFile);
                return await package.GetAsByteArrayAsync();
            }
        }
    }
}