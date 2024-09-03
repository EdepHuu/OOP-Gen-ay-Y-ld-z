namespace Lesson3
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Class Members
			#region Field

			// Nesne(object) içerisinde veri depoladığımız alanlardır. Değer tutar.
			// Field sadece ve sadece sınıfın içerisinde tanımlanmış değişkenlere denir.
			MyClass m1 = new MyClass(); // Bu işlem ile MyClass'dan bir nesne oluşturmuş oluyoruz!
			m1.sayi = 22;
			m1.kelime = "Metehan";
			MyClass m2 = new MyClass(); // Bu işlem ile MyClass'dan bir nesne oluşturmuş oluyoruz!
			m2.sayi = 20;
			m1.kelime = "Betül"; 

			#endregion
			#region
			#endregion
			#region
			#endregion
			#endregion
		}
	}
	class MyClass
	{
		public int sayi; // Bunu yaparak bu class'dan üretilecek olan nesneler'de sayi alanını tanımlamış oluyoruz.
						 // MyClass'dan üretilen tüm nesnelerde "sayi" isminde bir alan olacaktır.
		public string? kelime;
	}
}
