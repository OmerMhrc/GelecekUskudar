using System;

namespace GelecekUskudar.Models
{
    public class Ogrenci
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int OgrenimDurumu { get; set; }
        public int MulakatNotu { get; set; }
        public string TelefonNumarasi{get; set;}
        public bool ReferansMektubu { get; set; }
        public bool NiyetMektubu { get; set; }
        public string OgretmenYorumu { get; set; }
    }
}