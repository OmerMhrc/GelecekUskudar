using GelecekUskudar.Models;
using System.Collections.Generic;

namespace GelecekUskudar.Repositories
{
    public class OgrenciRepository
    {
        private static readonly List<Ogrenci> _ilkokul = new List<Ogrenci>();
        private static readonly List<Ogrenci> _ortaokul = new List<Ogrenci>();
        private static readonly List<Ogrenci> _lise = new List<Ogrenci>();
        public static List<Ogrenci> IlkOkulData()
        {   
            return _ilkokul;
        }

        public static List<Ogrenci> OrtaOkulData()
        {
            return _ortaokul;
        }

        public static List<Ogrenci> LiseData()
        {
            return _lise;
        }

        public static void addOgrenci(Ogrenci ogrenci) {

            if (ogrenci.OgrenimDurumu == 1)
            {
                _ilkokul.Add(ogrenci);
            }
            else if (ogrenci.OgrenimDurumu == 2)
            {
                _ortaokul.Add(ogrenci);
            }
            else if (ogrenci.OgrenimDurumu == 3)
            {
                _lise.Add(ogrenci);
            }

        }
    }
}


/* _ogrenciler.Add(new Ogrenci()
            {
                Name = "Ömer",
                Surname = "Mühürcü",
                OgrenimDurumu = 1,
                TelefonNumarasi = "0-551-554-36-85",
                MulakatNotu = 100,
                ReferansMektubu = true,
                NiyetMektubu=false,
                OgretmenYorumu = "okuldaki en iyi öğrenci ayrıca yakışıklı"
            });*/
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