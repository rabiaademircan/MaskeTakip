using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim:"Rabia");
            SelamVer(isim:"Ayşe");
            SelamVer(isim:"Fatma");
            SelamVer();


            int sonuc = Topla(3,5);

            // Diziler / Arrays
            string ogrenci1 = "Rabia";
            string ogrenci2 = "Ayşe";
            string ogrenci3 = "Fatma";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Rabia";
            ogrenciler[1] = "Ayşe";
            ogrenciler[2] = "Fatma";

            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İzmir", "İstanbul" };
            string[] sehirler2 = new[] { "Tokat", "Antalya", "Kayseri" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "RABİA";
            person1.LastName = "DEMİRCAN";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Ayşe";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yenisehirler1 = new List<string> { "Ankara 1", "İzmir 1", "İstanbul 1" };
            yenisehirler1.Add("Adana 1");
            foreach (string yenisehir in yenisehirler1)
            {
                Console.WriteLine(yenisehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        static void SelamVer(string isim ="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :"+ sonuc.ToString());
            return sonuc ;
        }

        private static void Degiskenler()
        {
            string mesaj = "selam";
            double tutar = 100000;//db den gelir.
            int sayi = 100;
            bool girisYapmismi = false;

            string Ad = "Rabia";
            string Soyad = "Demircan";
            int DogumYili = 2004;
            long TcNo = 12345678910;


            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
