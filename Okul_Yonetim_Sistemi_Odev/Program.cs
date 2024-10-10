using System;
using System.Collections;

namespace Okul_Yonetim_Sistemi_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HosGeldiniz();

            static void HosGeldiniz()
            {
                Console.WriteLine("Hoş geldiniz. Yapmak İstediğiniz İşlem İçin Tuşlama Yapınız.");
                while (true)
                {
                    Console.WriteLine("1- Öğrenci Girişi \n 2- Öğretmen Girişi \n 3- Yönetici Girişi ");
                    try
                    {
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            OgrenciGiris();
                            break;
                        }
                        else if (secim == 2)
                        {
                            OgretmenGiris();
                            break;
                        }
                        else if (secim == 3)
                        {
                            YoneticiGiris();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen Rakam Tuşlayınız.");
                    }
                }
            }
            static void OgrenciGiris()
            {
                int ogrenciNumarasi = 1234;
                int ogrenciSifresi = 123;
                int ogrenciHak = 3;
                while (ogrenciHak > 0)
                {
                    Console.WriteLine("Öğrenci Numaranızı Girin:");
                    int ogrenciNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Şifrenizi Girin:");
                    int ogrenciSifre = Convert.ToInt32(Console.ReadLine());

                    if (ogrenciNumarasi == ogrenciNo && ogrenciSifresi == ogrenciSifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    }
                    else
                    {
                        ogrenciHak--;
                        Console.WriteLine("Giriş Başarısız.Kalan Hakkınız: " + (ogrenciHak));
                        if (ogrenciHak == 0)
                        {
                            Console.WriteLine("Şifre Deneme Hakkınız Kalmadı!");
                            Thread.Sleep(3000);
                            ogrenciHak = 3;
                            Console.Clear();
                        }
                    }
                }
                Ogrenci();


            }
            static void OgretmenGiris()
            {
                int ogretmenNumarasi = 1111;
                int ogretmenSifresi = 1234;
                int ogretmenHak = 3;
                while (ogretmenHak > 0)
                {
                    Console.WriteLine("Öğretmen Numaranızı Girin:");
                    int ogretmenNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Şifrenizi Girin:");
                    int ogretmenSifre = Convert.ToInt32(Console.ReadLine());

                    if (ogretmenNumarasi == ogretmenNo && ogretmenSifre == ogretmenSifresi)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        ogretmenHak--;
                        Console.WriteLine("Giriş Başarısız.Kalan Hakkınız: " + (ogretmenHak));
                        if (ogretmenHak == 0)
                        {
                            Console.WriteLine("Şifre Deneme Hakkınız Kalmadı!");
                            Thread.Sleep(3000);
                            ogretmenHak = 3;
                        }
                    }
                }
                Ogretmen();
            }
            static void YoneticiGiris()
            {
                int yoneticiNumarasi = 10;
                int yoneticiSifresi = 1234;
                int yoneticiHak = 3;
                while (yoneticiHak > 0)
                {
                    Console.WriteLine("Yönetici Numaranızı Girin:");
                    int yoneticiNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Şifrenizi Girin:");
                    int yoneticiSifre = Convert.ToInt32(Console.ReadLine());

                    if (yoneticiNumarasi == yoneticiNo && yoneticiSifre == yoneticiSifresi)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        yoneticiHak--;
                        Console.WriteLine("Giriş Başarısız.Kalan Hakkınız: " + yoneticiHak);
                        if (yoneticiHak == 0)
                        {
                            Console.WriteLine("Şifre Deneme Hakkınız Kalmadı!");
                            Thread.Sleep(3000);
                        }
                    }
                }
                Yonetici();

            }
            static void Yonetici()
            {
                Console.WriteLine("Yapmak İstediğiniz İşlem İçin Tuşlama Yapınız.");
                while (true)
                {
                    Console.WriteLine("1-Öğrenci Yönetimi \n 2-Öğretmen Yönetimi \n 3-Çıkış");
                    try
                    {
                        int tuslama = Convert.ToInt32(Console.ReadLine());
                        if (tuslama == 1)
                        {
                            Console.WriteLine("1-Öğrenci Ekle \n 2-Öğrenci Çıkar \n 3-Öğrenci Bilgisi Güncelle\n 4- Öğrenci Listesi Görüntüle");
                            int yoneticiSecim1 = Convert.ToInt32(Console.ReadLine());
                            if (yoneticiSecim1 == 1)
                            {
                                OgrenciEkle();
                            }
                            else if (yoneticiSecim1 == 2)
                            {
                                OgrenciCikar();
                            }

                            else if (yoneticiSecim1 == 3)
                            {
                                OgrenciGuncelle();
                            }
                            else if (yoneticiSecim1 == 4)
                            {
                                OgrenciListele();
                            }
                            else
                            { Console.WriteLine("Hatalı Tuşlama Yaptınız."); }
                        }
                        else if (tuslama == 2)
                        {

                            Console.WriteLine("1-Öğretmen Ekle \n 2-Öğretmen Çıkar \n 3-Öğretmen Bilgisi Güncelle\n 4- Öğretmen Listesi Görüntüle");
                            int yoneticiSecim2 = Convert.ToInt32(Console.ReadLine());
                            if (yoneticiSecim2 == 1)
                            {
                                OgretmenEkle();
                            }
                            else if (yoneticiSecim2 == 2)
                            {
                                OgretmenCikar();
                            }

                            else if (yoneticiSecim2 == 3)
                            {
                                OgretmenGuncelle();
                            }
                            else if (yoneticiSecim2 == 4)
                            {
                                OgretmenListele();
                            }
                            else
                            { Console.WriteLine("Hatalı Tuşlama Yaptınız."); }
                        }
                        else if (tuslama == 3)
                        {
                            Console.WriteLine("Çıkış Yapılıyor..");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                        }

                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                        }
                    }
                    catch (FormatException) { }
                }
            }
            static void OgrenciEkle()
            {
                Console.WriteLine("Eklenecek Öğrenci Adı Soyadı");
                string yeniOgrenciAd = Console.ReadLine();
                Array.Resize(ref OgrenciListe.ogrenciIsim, OgrenciListe.ogrenciIsim.Length + 1); // Dizinin boyutunu 1 arttırır.
                OgrenciListe.ogrenciIsim[OgrenciListe.ogrenciIsim.Length - 1] = yeniOgrenciAd; //Arttırılan dizinin son elemanına yeni elemanı ekler
                Console.WriteLine("Eklenecek Öğrenci Yaşı");
                string yeniOgrenciYas = Console.ReadLine();
                Array.Resize(ref OgrenciListe.ogrenciYas, OgrenciListe.ogrenciYas.Length + 1);
                OgrenciListe.ogrenciYas[OgrenciListe.ogrenciYas.Length - 1] = yeniOgrenciYas;

            }
            static void OgrenciCikar()
            {
                while (true)
                {
                    Console.WriteLine("Çıkarmak İstediğiniz Öğrenciyi Seçiniz");
                    OgrenciListele();
                    try
                    {
                        int ogrenciCikar = Convert.ToInt32(Console.ReadLine());
                        if (ogrenciCikar > 0 && ogrenciCikar <= OgrenciListe.ogrenciIsim.Length)
                        {
                            List<string> cikanOgrenciListesi = OgrenciListe.ogrenciIsim.ToList();
                            cikanOgrenciListesi.RemoveAt(ogrenciCikar);
                            OgrenciListe.ogrenciIsim = cikanOgrenciListesi.ToArray();
                            List<string> cikanOgrenciYas = OgrenciListe.ogrenciYas.ToList();
                            cikanOgrenciYas.RemoveAt(ogrenciCikar);
                            OgrenciListe.ogrenciYas = cikanOgrenciYas.ToArray();
                            Console.WriteLine("Öğrenci Listeden Çıkarıldı.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Güncellenmiş Öğrenci Listesi");
                            OgrenciListele();
                            Thread.Sleep(3000);
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Hatalı Öğrenci Seçimi");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                    }
                }

            }
            static void OgrenciGuncelle()
            {
                while (true)
                {
                    Console.WriteLine("Güncellemek İstediğiniz Öğrenciyi Seçiniz");
                    OgrenciListele();
                    int ogrenciGuncelleme = Convert.ToInt32(Console.ReadLine());
                    if (ogrenciGuncelleme > 0 && ogrenciGuncelleme <= OgrenciListe.ogrenciIsim.Length)
                    {
                        Console.WriteLine("Öğrencinin Yeni Adını Soyadını Giriniz");
                        string ogrenciYeniAd = Console.ReadLine();
                        OgrenciListe.ogrenciIsim[ogrenciGuncelleme] = ogrenciYeniAd;
                        Console.WriteLine("Öğrencinin Yeni Yaşını Giriniz");
                        string ogrenciYeniYas = Console.ReadLine();
                        OgrenciListe.ogrenciYas[ogrenciGuncelleme] = ogrenciYeniYas;
                        Console.WriteLine("Öğrenci Bilgisi Güncellendi\n Güncellenmiş Öğrenci Listesi");
                        Console.Clear();
                        OgrenciListele();
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Öğrenci Seçimi");

                    }
                }

            }
            static void OgrenciListele()
            {

                {
                    for (int i = 0; i < OgrenciListe.ogrenciIsim.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{OgrenciListe.ogrenciIsim[i]}");
                    }

                }

            }
            static void OgretmenEkle()
            {
                Console.WriteLine("Eklenecek Öğretmen Adı Soyadı");
                string yeniOgretmenAd = Console.ReadLine();
                Array.Resize(ref ogretmenListe.ogretmenIsim, ogretmenListe.ogretmenIsim.Length + 1);
                ogretmenListe.ogretmenIsim[ogretmenListe.ogretmenIsim.Length - 1] = yeniOgretmenAd;
                Console.WriteLine("Eklenecek Öğretmen Yaşı");
                string yeniOgretmenYas = Console.ReadLine();
                Array.Resize(ref ogretmenListe.ogretmenYas, ogretmenListe.ogretmenYas.Length + 1);
                ogretmenListe.ogretmenYas[ogretmenListe.ogretmenYas.Length - 1] = yeniOgretmenYas;

            }
            static void OgretmenCikar()
            {
                while (true)
                {
                    Console.WriteLine("Çıkarmak İstediğiniz Öğretmen Seçiniz");
                    OgretmenListele();
                    try
                    {
                        int ogretmenCikar = Convert.ToInt32(Console.ReadLine());
                        if (ogretmenCikar > 0 && ogretmenCikar <= ogretmenListe.ogretmenIsim.Length)
                        {
                            List<string> cikanOgretmenListesi = ogretmenListe.ogretmenIsim.ToList();
                            cikanOgretmenListesi.RemoveAt(ogretmenCikar);
                            ogretmenListe.ogretmenIsim = cikanOgretmenListesi.ToArray();
                            List<string> cikanOgretmenYas = ogretmenListe.ogretmenYas.ToList();
                            cikanOgretmenYas.RemoveAt(ogretmenCikar);
                            ogretmenListe.ogretmenYas = cikanOgretmenYas.ToArray();
                            Console.WriteLine("Öğretmen Listeden Çıkarıldı.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Güncellenmiş Öğretmen Listesi");
                            OgretmenListele();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Öğretmen Seçimi");
                        }
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                    }
                }

            }
            static void OgretmenGuncelle()
            {
                while (true)
                {
                    Console.WriteLine("Güncellemek İstediğiniz Öğretmeni Seçiniz");
                    OgretmenListele();
                    int ogretmenGuncelleme = Convert.ToInt32(Console.ReadLine());
                    if (ogretmenGuncelleme > 0 && ogretmenGuncelleme <= ogretmenListe.ogretmenIsim.Length)
                    {
                        Console.WriteLine("Öğretmenin Yeni Adını Soyadını Giriniz");
                        string ogretmenYeniAd = Console.ReadLine();
                        ogretmenListe.ogretmenIsim[ogretmenGuncelleme] = ogretmenYeniAd;
                        Console.WriteLine("Öğretmenin Yeni Yaşını Giriniz");
                        string ogretmenYeniYas = Console.ReadLine();
                        ogretmenListe.ogretmenIsim[ogretmenGuncelleme] = ogretmenYeniYas;
                        Console.WriteLine("Öğretmen Bilgisi Güncellendi\n Güncellenmiş Öğretmen Listesi");
                        Console.Clear();
                        OgretmenListele();
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Öğretmen Seçimi");

                    }
                }

            }
            static void OgretmenListele()
            {

                {
                    for (int i = 0; i < ogretmenListe.ogretmenIsim.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{ogretmenListe.ogretmenIsim[i]}");
                    }

                }

            }
            static void Ogrenci()
            {
                while (true)
                {
                    Console.WriteLine("1-Ders Ekle\n2-Ders Çıkar\n3-Ders Programı Görüntüle\n4-Not Görüntüle\n5-Çıkış");
                    try
                    {
                        int ogrenciSecim = Convert.ToInt32(Console.ReadLine());
                        if (ogrenciSecim == 1)
                        {
                            DersEkleOgrenci();

                        }
                        else if (ogrenciSecim == 2)
                        {
                            DersCikarOgrenci();

                        }
                        else if (ogrenciSecim == 3)
                        {
                            OgrenciDersProgrami();

                        }
                        else if (ogrenciSecim == 4)
                        {
                            OgrenciNotGoruntule();
                        }
                        else if (ogrenciSecim == 5)
                        {
                            Console.WriteLine("Çıkış Yapılıyor..");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen Rakam Tuşlayınız.");
                    }
                }
            }
            static void DersEkleOgrenci()
            {
                while (true)
                {
                    Console.WriteLine("Eklemek İstediğiniz Dersi Seçiniz");
                    DerslerListele();

                    string input = (Console.ReadLine());
                    if (int.TryParse(input, out int dersindex) && dersindex >= 0 && dersindex <= Dersler.dersIsimleri.Length)
                    {
                        string yeniDers = Dersler.dersIsimleri[dersindex - 1];
                        if (!OgrenciListe.ogrenciDersProgrami.Contains(yeniDers))
                        {
                            Array.Resize(ref OgrenciListe.ogrenciDersProgrami, OgrenciListe.ogrenciDersProgrami.Length + 1);
                            OgrenciListe.ogrenciDersProgrami[OgrenciListe.ogrenciDersProgrami.Length - 1] = yeniDers;
                            Console.WriteLine("Seçilen Ders, Ders Programına Başarıyla Eklendi.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Yeni Ders Programınız");
                            OgrenciDersProgrami();
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bu Ders, Ders Programınızda Zaten Var!\n Başka Ders Eklemek İçin 1'e Çıkış Yapmak İçin Q'ya Basınız.");
                            string cikis = Console.ReadLine();
                            if (cikis.ToUpper() == "Q")
                            {
                                Console.WriteLine("Çıkış Yapılıyor..");
                                Environment.Exit(0);
                            }
                            else if (cikis == "1")
                            { continue; }

                        }
                    }
                }
            }
            static void DersCikarOgrenci()
            {
                Console.WriteLine("Çıkarmak İstediğiniz Dersi Seçiniz");
                OgrenciDersProgrami();
                try
                {
                    int dersCikar = Convert.ToInt32(Console.ReadLine());
                    if (dersCikar >= 0 && dersCikar <= OgrenciListe.ogrenciDersProgrami.Length)
                    {
                        List<string> CikanDers = OgrenciListe.ogrenciDersProgrami.ToList();
                        CikanDers.RemoveAt(dersCikar);
                        OgrenciListe.ogrenciDersProgrami = CikanDers.ToArray();
                        Console.WriteLine("Ders Programınızdan Çıkarıldı.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Güncellenmiş Ders Listesi");
                        OgrenciDersProgrami();
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ders Seçimi");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                }

            }
            static void OgrenciDersProgrami()
            {
                {
                    for (int i = 0; i < OgrenciListe.ogrenciDersProgrami.Length; i++)
                    {
                        Console.WriteLine($"{i}-{OgrenciListe.ogrenciDersProgrami[i]}");
                    }

                }
            }
            static void DerslerListele()
            {
                {
                    for (int i = 0; i < Dersler.dersIsimleri.Length; i++)
                    {
                        Console.WriteLine($"{i}-{Dersler.dersIsimleri[i]}");
                    }

                }
            }
            static void OgrenciNotGoruntule()
            {
                
                Console.WriteLine("Sisteme Girilmiş Notlarınız:\n *****Matematik Vize*****");
                
                NotListeleMat();
                Thread.Sleep(3000);
                Console.Clear();

            }
            static void Ogretmen()
            {
                while (true)
                {
                    Console.WriteLine("1-Ders Ekle\n2-Ders Çıkar\n3-Ders Programı Görüntüle\n4-Not Gir\n5-Çıkış");
                    try
                    {
                        int ogretmenSecim = Convert.ToInt32(Console.ReadLine());
                        if (ogretmenSecim == 1)
                        {
                            DersEkleOgretmen();
                        }
                        else if (ogretmenSecim == 2)
                        {
                            DersCikarOgretmen();

                        }
                        else if (ogretmenSecim == 3)
                        {
                            OgretmenDersProgrami();
                        }
                        else if (ogretmenSecim == 4)
                        {
                            NotGirFinal();
                        }
                        else if (ogretmenSecim == 5)
                        {
                            Console.WriteLine("Çıkış Yapılıyor..");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen Rakam Tuşlayınız.");
                    }

                }
            }
            static void DersEkleOgretmen()
            {
                while (true)
                {
                    Console.WriteLine("Eklemek İstediğiniz Dersi Seçiniz");
                    DerslerListele();

                    string input = (Console.ReadLine());
                    if (int.TryParse(input, out int dersindex) && dersindex >= 1 && dersindex <= Dersler.dersIsimleri.Length)
                    {
                        string yeniDers = Dersler.dersIsimleri[dersindex - 1];
                        if (!ogretmenListe.ogretmenDersProgrami.Contains(yeniDers))
                        {
                            Array.Resize(ref ogretmenListe.ogretmenDersProgrami, ogretmenListe.ogretmenDersProgrami.Length + 1);
                            ogretmenListe.ogretmenDersProgrami[ogretmenListe.ogretmenDersProgrami.Length - 1] = yeniDers;
                            Console.WriteLine("Seçilen Ders, Ders Programına Başarıyla Eklendi.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Yeni Ders Programınız");
                            OgretmenDersProgrami();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bu Ders, Ders Programınızda Zaten Var!\n Başka Ders Eklemek İçin 1'e Çıkış Yapmak İçin Q'ya Basınız.");
                            string cikis = Console.ReadLine();
                            if (cikis.ToUpper() == "Q")
                            {
                                Console.WriteLine("Çıkış Yapılıyor..");
                                Environment.Exit(0);
                            }
                            else if (cikis == "1")
                            { continue; }

                        }
                    }
                }

            }
            static void DersCikarOgretmen()
            {
                Console.WriteLine("Çıkarmak İstediğiniz Dersi Seçiniz");
                OgretmenDersProgrami();
                try
                {
                    int dersCikar = Convert.ToInt32(Console.ReadLine());
                    if (dersCikar >=0 && dersCikar <= ogretmenListe.ogretmenDersProgrami.Length)
                    {
                        List<string> CikanDers = ogretmenListe.ogretmenDersProgrami.ToList();
                        CikanDers.RemoveAt(dersCikar);
                        ogretmenListe.ogretmenDersProgrami = CikanDers.ToArray();
                        Console.WriteLine("Ders,Programınızdan Çıkarıldı.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Güncellenmiş Ders Listesi");
                        OgretmenDersProgrami();
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ders Seçimi");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                }

            }
            static void OgretmenDersProgrami()
            {
                {
                    for (int i = 0; i < ogretmenListe.ogretmenDersProgrami.Length; i++)
                    {
                        Console.WriteLine($"{i}-{ogretmenListe.ogretmenDersProgrami[i]}");
                    }
                }

            }
            static void NotGirFinal()
            {
                while (true)
                {
                    try
                    {

                        for (int i = 0; i < OgrenciListe.ogrenciNotFinalMat.Length; i++)
                        {
                            OgrenciListe.ogrenciNotFinalMat[i] = new ArrayList();
                        }
                        Console.WriteLine("Not Girmek İstediğiniz Öğrenciyi Seçiniz veya Çıkış Yapmak İçin 0'ı Tuşlayınız");
                        OgrenciListele();
                        int ogrenciSecim = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (ogrenciSecim >= 0 && ogrenciSecim <= OgrenciListe.ogrenciIsim.Length)
                        {
                            Console.WriteLine("Notu Giriniz:");
                            int notFinal= Convert.ToInt32(Console.ReadLine());
                            OgrenciListe.ogrenciNotFinalMat[ogrenciSecim].Add(notFinal);
                            Console.WriteLine($"{OgrenciListe.ogrenciIsim[ogrenciSecim]} Adlı Öğrenciye {notFinal} Notu Eklendi.");
                            Thread.Sleep(3000);
                            Console.Clear();

                        }
                        else if (ogrenciSecim==0)
                        {
                            Console.WriteLine("Çıkış Yapılıyor..");
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                            
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                        }
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen Rakam Tuşlayınız!");
                    }
                }
            }
            static void NotListeleMat()
            {
                for (int i = 0; i < OgrenciListe.ogrenciIsim.Length; i++)
                {
                    Console.WriteLine($"{i+1}-{OgrenciListe.ogrenciIsim[i]} / {OgrenciListe.ogrenciNotVizeMat[i]}");
                }
            }
        }

    }
}

