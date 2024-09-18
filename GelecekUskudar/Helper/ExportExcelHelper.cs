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
                worksheet.Cells["E1"].Value = "Telefon Numarası"; 
                worksheet.Cells["F1"].Value = "Ögretmen Yorumu";
                worksheet.Cells["G1"].Value = "Referans Mektubu";
                worksheet.Cells["H1"].Value = "Niyet Mektubu";

                worksheet.Column(3).Width = 15; // Öğrenim Durumu sütunu
                worksheet.Column(4).Width = 15; // Öğrenci Notu sütunu
                worksheet.Column(5).Width = 18;
                worksheet.Column(6).Width = 40;
                worksheet.Column(7).Width = 20;
                worksheet.Column(8).Width = 15;

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
                    
                    worksheet.Cells[rowIndex, 4].Value = ogrenci.MulakatNotu;
                    worksheet.Cells[rowIndex, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    worksheet.Cells[rowIndex, 5].Value = ogrenci.TelefonNumarasi;
                    worksheet.Cells[rowIndex, 6].Value = ogrenci.OgretmenYorumu;

                    if (ogrenci.ReferansMektubu == true)
                    {
                        worksheet.Cells[rowIndex, 7].Value = "Var";
                    }
                    else
                    {
                        worksheet.Cells[rowIndex, 7].Value = "Yok";
                    }

                    if (ogrenci.NiyetMektubu == true)
                    {
                        worksheet.Cells[rowIndex, 8].Value = "Var";
                    }
                    else
                    {
                        worksheet.Cells[rowIndex, 8].Value = "Yok";
                    }

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