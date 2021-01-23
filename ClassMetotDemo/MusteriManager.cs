using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class MusteriManager
	{
		List<Musteri> musteriler = new List<Musteri> { }; // müsteri bilgisini tutmak için

		public void MusteriEkleme(Musteri musteri)
		{
			Console.WriteLine("--------Musteri Ekleme--------");
			Console.WriteLine("{0} İsimli Musteri Eklendi!!\n",musteri.Ad);
			musteriler.Add(musteri);
		}

		public void MusteriListele()
		{
			Console.WriteLine("--------Musteri Listeleme--------\n");
			
			foreach (var musteri in musteriler)
			{
				Console.WriteLine(
					"Ad: " + musteri.Ad + " " +
					"Soyad: " + musteri.Soyad + " " +
					"Yas: " + musteri.Yas + " " +
					"Id: " + musteri.Id + " " +
					"Adres: " + musteri.Adres);
			}
		}

		public void MusteriSilme(Musteri musteri)
		{
			Console.WriteLine("\n--------Musteri Silme--------\n");
			Console.WriteLine("{0} isimli müsteri silinmiştir.\n",musteri.Ad);
			musteriler.Remove(musteri);
		}
	}
}