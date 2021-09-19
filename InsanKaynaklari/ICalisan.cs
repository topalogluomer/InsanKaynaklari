using System;
using System.Collections.Generic;
using System.Text;

namespace InsanKaynaklari
{
    interface ICalisan //belirledigim isme ait bir arayüz
        //sınıfları insa ederken kuralları baştan koymak icin
        //erişim seviyesi söylenmez, prosedür veya metot oldugunu söylemek yeterli
        //bi mimari belirlenir, diğer taraftaki seyler omna göre yapılır
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int SicilNo { get; set; }
        DateTime IseAlimTarihi { get; set; }

        decimal Maas { get; set; } 

    }
}
