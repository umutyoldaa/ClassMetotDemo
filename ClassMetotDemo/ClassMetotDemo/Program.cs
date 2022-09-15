// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Musteri musteri5 = new Musteri();
musteri5.TcNo = 12;
musteri5.Isim = "Yunus";
musteri5.SoyIsim="aslan";
musteri5.Id = 5;

Musteri musteri1 = new Musteri();
musteri1.TcNo = 1213;
musteri1.Isim = "Emre";
musteri1.SoyIsim = "koc";
musteri1.Id = 4;

Musteri musteri2 = new Musteri();
musteri2.TcNo = 13;
musteri2.Isim = "Selin";
musteri2.SoyIsim = "Ozbek";
musteri2.Id = 3;

Musteri musteri3 = new Musteri();
musteri3.TcNo = 14;
musteri3.Isim = "Asli";
musteri3.SoyIsim = "Enver";
musteri3.Id = 2;

Musteri musteri4 = new Musteri();
musteri4.TcNo = 15;
musteri4.Isim = "Ahmet";
musteri4.SoyIsim = "Durak";
musteri4.Id = 1;

MusteriManager func = new MusteriManager();
func.MusteriEkle(musteri5);
func.MusteriEkle(musteri4);
func.MusteriEkle(musteri3);
func.MusteriEkle(musteri2);
func.MusteriEkle(musteri1);

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

func.MusteriListe(musteriler);
func.MusteriSilme(musteri4);
func.MusteriSilme(musteri3);
func.MusteriSilme(musteri2);
func.MusteriListe(musteriler);


