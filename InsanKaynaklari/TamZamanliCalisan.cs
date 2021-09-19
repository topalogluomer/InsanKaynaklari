using System;
using System.Collections.Generic;
using System.Text;

namespace InsanKaynaklari
{
    public sealed class TamZamanliCalisan : Calisan //türetilemez miras verilemez anlamını taşır.(Sealed)
    {
        public TamZamanliCalisan(string ad, string soyad):base(ad, soyad) //ad soyadı abstract olarak açtım calısan.cs de. base gösterimini yaptım.
        {
            Ad = ad;
            Soyad = soyad;

        }

        public override decimal Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //maaşa abstract uyguladıgım icin +
        public override string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Soyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //buraya override istiyor
        public override decimal MaasHesapla() //maaşı ben burda hesaplıcam orda değil..! Base burda 
        {
            return base.MaasHesapla();
        }
    }
}
