
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            //Console.WriteLine(args[0]);            

            #region Ek Bilgiler

            // region fonksiyonu yazılan kodların karmaşısını engellemek için kullanılır.

            //todo  Bu şekilde açıklama yapılırsa bu satır TaskList e düşer. Yani yapılması gereken bir işi bu şekilde belirtebiliriz.


            #endregion

            #region Tür Dönüşümleri

            #region Parse Metodu
            // Parse metodu sadece string dataları hedef türe dönüştürürken kullanılır!
            string x1 = "123";
            //Console.WriteLine(short.Parse(x1) * 5);
            short x2 = short.Parse(x1);
            Console.WriteLine(x2 * 5);


            #endregion
            #region Convert Fonksiyonları
            string x3 = "25";
            int x4 = Convert.ToInt32(x3);


            #endregion
            #region ToString Fonksiyonu
            //ToString fonksiyonu tüm türlerde mevcuttur.
            int x5 = 456;
            string y2 = x5.ToString();

            #endregion

            #region Bilinçsiz Tür Dönüşümü
            //Bir sayısal türün kendisinden daha geniş aralıktaki başka bir türe atanması bilinçsiz tür dönüşümüdür.

            //Örnek
            short x6 = 123;
            long y3 = x6;

            #endregion
            #region Bilinçli Tür Dönüşümü
            // Bir sayısal türün kendisinden daha dar aralıkta başka türe atanması bilinçli tür dönüşümüdür.
            // Veri kaybı olabileceği için sorumluluğu biz alırız.
            int x7 = 4588;
            short y4 = (short)x7;


            #endregion
            #region checked
            //Bilinçli tür dönüşümü sırasında veri kaybı olacak olursa runtime'da uyarı verecek kontrol mekanizması.
            checked
            {
                //int a1 = 500;
                //byte b1 = (byte)a1;
                //Console.WriteLine(b1);
            }

            #endregion
            #region unchecked
            //Bilinçli tür dönüşümü sırasında veri kaybı olacak olursa uyarı vermez.
            unchecked
            {
                int a2 = 500;
                byte b2 = (byte)a2;
                Console.WriteLine(b2);
            }


            #endregion


            #endregion






        }



    }



}








