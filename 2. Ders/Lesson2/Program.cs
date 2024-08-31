using System;

namespace Lesson2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Sınıf Nasıl ve nerede oluşturulur?

			#region Namespace içerisinde
			// Aynı namespace içerisinde birden fazla class var ise bu classlar birbirine kolayca erisebilirler. Farkli bir
			// namespace içerisindeki classa erişmek istersek o namespace üzerinden erişebiliriz.
			#endregion
			#region Namespace dışarısında
			// Herkes erişebilir. Erişirken Namespace belirtmeye gerek yoktur.
			#endregion
			#region Class içinde (Nested Type)
			#endregion

			// Bir class tanimlamasinda tanimlanan yerde(yukarıdaki 3 yerden biri), aynı isimde birden fazla class tanimlanamaz!

			#endregion

			#region Sınıf ile Nesne modeli tasarlama
			/*
				OrnekModel classi ile Nesnenin Modellemesini yapalim.
			*/
			#endregion

			#region Sinif Modelinden referans noktasi olusturma
			/*
				Bir class tanimlandiginda o class adi bir türe karsilik gelir. O türü kullanabilmek icin direkt olarak class adini
				kulanmamiz yeterlidir. 
				Örneğin : OrnekModel ornekmodelx; şeklinde biz o türden bir referans noktası olusturabiliriz. 
				Kısacasi burada bir class'in türünden bir değişken oluşturuyoruz. 
				OrnekModel ornekmodelx; bu şekildeki kullanımda herhangi bir nesneyi işaretlemiyoruz. Bu yüzden burada null degere sahip.
			*/
			#endregion
		}
	}
	class OrnekModel
	{
		int a; // Class'in icerisinde olusturulan degiskenlere field yani alan denir.
		int b; // Class'in icerisinde olusturulan degiskenlere field yani alan denir.
		public void Fonksiyon()
		{
			Console.WriteLine(a + " " + b);
		}
		public int Fonksiyon2()
		{
			return a*b;
		}

	}
}
