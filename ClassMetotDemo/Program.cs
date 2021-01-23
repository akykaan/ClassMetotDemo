using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hoşgeldiniz");

			Musteri musteri = new Musteri(); //ilk müşterimizi oluşturduk
			musteri.Ad = "Furkan Kaan";
			musteri.Soyad = "Akyüz";
			musteri.Yas = 26;
			musteri.Id = 1;
			musteri.Adres = "Ankara";

			Musteri musteri1 = new Musteri();
			musteri1.Ad = "Dilara";
			musteri1.Soyad = "Orhan";
			musteri1.Yas = 22;
			musteri1.Id = 2;
			musteri1.Adres = "Ankara";


			MusteriManager musteriManager = new MusteriManager();
			musteriManager.MusteriEkleme(musteri); // ilk müşterimizi ekledik
			musteriManager.MusteriEkleme(musteri1);

			musteriManager.MusteriListele(); // müsteri listeleme

			musteriManager.MusteriSilme(musteri); // müsteri Silme

			musteriManager.MusteriListele(); // listenin son haline bakmak için çağırdık

		}
	}
}