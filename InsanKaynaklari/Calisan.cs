using System;
using System.Collections.Generic;
using System.Text;

namespace InsanKaynaklari
{/// <summary>
/// Korumalu Sınıf (sealed)
/// Korumalı sınıfı miras verilen sınıf olarak kullanılamaz
/// korumalı sınıflar türetmeyi engeller
/// </summary>
    public abstract class Calisan : ICalisan //burda hata veriyorsa interface de olan sey burda yok koymak zorundasın demektir.
    {
        private const double DamgaVergisi = 0.001;

        private decimal _maas;

        //kalıtım koyarsan ve zorunlu olarak kullandırtacaksan abstract(soyutlama) devereye giriyor. public abstract class yaptım
       

        
       
        public EgitimDurumu EgitimSeviyesi { set; get; } //EgitimDurumu nu veri tipi olarak kullandım. veri tipi olarak atama yaptım(aynı olamayacagından dolayı egitimseviyesi yaptım
        public abstract string Ad { get ; set; }
        public abstract string Soyad { get ; set; }
        int ICalisan.SicilNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime ICalisan.IseAlimTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public abstract decimal Maas { get; set; } //abstract yerleştirdigim icin diğer tarafta mecbur yapmak zorundayım. Override

        //enum özel bi deyim(bayraklama) kullanımı güzzelleştirir bankalardaki hataların ne hatası oldugunu söylemesi gibi.
        //anlasılabilir düzeyde ifade ediyor.

        public enum EgitimDurumu : byte
        {
            IlkOgretim = 1,
            OrtaOgretim = 2,   //sıralı yazarsam sadece 1 desem ve sondaki 6 yı versem de yeterli
            OnLisans = 3,
            Lisans = 4,
            YuksekLisans = 5,
            Doktora = 6
        }

        public virtual decimal MaasHesapla() //virtual düzeye cıkarma sebebim;metotu kullanabilirsin, istersen farklı da kullanabilirsin.Polimorfizm.
            //başta abstract ile soyutladım, maaşı hesaplarken de çeşitliliği arttırıyorum.
            //virtual verirsem override yapabiliyorum diğer sınıfta.!!! baika sınıfta türetmek icin kullanıyorum.
            //abstractların içinde bir sey olmaz boş olmak zorunda. throw falan olmıcak, egitimseviyesine de yapamazsın.
        {
            switch (EgitimSeviyesi)
            {
               
                case EgitimDurumu.OrtaOgretim:
                    _maas += _maas * (decimal)0.0009;
                    break;
                case EgitimDurumu.OnLisans:
                    _maas += _maas * (decimal)0.001;
                    break;
                case EgitimDurumu.Lisans:
                    _maas += _maas * (decimal)0.05;
                    break;
                case EgitimDurumu.YuksekLisans:
                    _maas += _maas * (decimal)0.09;
                    break;
                case EgitimDurumu.Doktora:
                    _maas += _maas * (decimal)0.5;
                    break;
                default:
                    _maas += _maas * (decimal)0.0005;
                       break;

            }
            return _maas;
        }

       //// protected Calisan()  //BUNU YOK ETTİGİM İCİN TAMZAMANLICALISAN DA HATA VERDİ ORDA CÖZÜMÜ GÖSTERDİK. MİRAS ALINANLARDA HATA VERDİ
       // {

       // }  
        protected Calisan(string ad, string soyad)
        {

        }
        ~Calisan() //yıkıcı metot, gerekli mi değil.Net zaten silip götürüyor.Garbage collector zaten yapıyor.
        {
            GC.Collect();
            //ÖZELLİK eklenebiliyor. Program kapanırken pc yi de kapatması icin.
        }

        }
    }

