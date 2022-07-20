
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine(args[0]);

            #region X Operasyonu

            // Karmaşıklık gidermek ve Kategorize etmek için kullanılan yöntem...






            #endregion

            //todo  Bu şekilde açıklama yapılırsa bu satır TaskList e düşer. Yani yapılması gereken bir işi bu şekilde belirtebiliriz.

            //Rakamsal değişkenlerin default türü integer'dır.
            //Ondalıklı Rakamsal değişkenlerin default türü double'dır            

            #region Tuple ile Değişken Tanımlama

            (int yas, string adi) kisi = (25, "Hasan");

            kisi.yas = 26;
            kisi.adi = "Ahmet";

            kisi = (27, "Mehmet");


            #endregion

            #region Literal Düzenleme(C# 7.0)

            // 1 milyon gibi okuması zor değerleri _(alt tire) işareti ile ayırarak tanımlayabiliriz.
            // Örn: int z = 1_000_000;


            #endregion

            #region Custom Scope

            {

                {
                    //Herhangi bir kod gerekmeden istediğimiz gibi scope açabiliriz
                }

            }
            {


            }
            #endregion

            #region Sabitler

            //const veya readonly ile tanımlanan değerler değiştirilemezler.

            const double pi = 3.14; //tanımlama aşamasında değeri atanır bir daha değiştirilemez

            // pi = 123; burada değeri değiştirmeye çalışırsak hata alırız.

            #endregion

            #region object
            //object: Tüm türleri karşılayabilen bir türdür. (int, string, char vs.)
            //object: Referans türlü bir değişkendir, fakat değer türlü değişkenleri de karşılayabilir.
            object a;
            a = "Ahmet";
            a = 3;
            a = 'D';

            //object türdeki bir değişkene herhangi bir türdeki değeri göndermek Boxing olarak nitelendirilir.
            
            object _yas = 28; //Boxing
            //_yas değişkeninde 28 değeri object türünde olduğu için matematiksel işlemler yapılamaz.
            //Değer üzerinde türüne özgü işlemler yapabilmek için Unboxing işlemi yapılmalıdır.
            //Cast Operatörü: Unboxing işlemi yapmamızı sağlayan operatör. Tür dönüşümlerinde de kullanılır.
            int yas = (int)_yas; //Unboxing
            //Cast Operatörü parantezdir.

            #endregion
        }



    }



}








