using GelecekUskudar.Models;
using System.Collections.Generic;

namespace GelecekUskudar.Repositories
{
    public class OgrenciRepository
    {
        private static readonly List<Ogrenci> _ogrenciler = new List<Ogrenci>();
        public static List<Ogrenci> OgrenciData()
        {
            _ogrenciler.Add(new Ogrenci()
            {
                Name = "Ömer",
                Surname = "Mühürcü",
                OgrenimDurumu = 1,
                OgrenciNotu = 100,
                OgretmenYorumu = "okuldaki en iyi öğrenci ayrıca yakışıklı"
            });
            /*List<Ogrenci> _ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Name = "Ömer",
                    Surname = "Mühürcü",
                    OgrenimDurumu = 1,
                    OgrenciNotu = 100,
                    OgretmenYorumu = "okuldaki en iyi öğrenci ayrıca yakışıklı"
                },
            };*/
            return _ogrenciler;
        }

        public static void addOgrenci(Ogrenci ogrenci) {
                _ogrenciler.Add(ogrenci);
        }
    }
}