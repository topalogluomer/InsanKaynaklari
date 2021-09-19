using System;
using System.Collections.Generic;
using System.Text;

namespace InsanKaynaklari
{
    public sealed class  YoneticiCalisan : Calisan
    {
        public YoneticiCalisan(string ad, string soyad) : base(ad, soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        public override decimal Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Soyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal MaasHesapla()
        {
            return base.MaasHesapla();
        }
    }
}
