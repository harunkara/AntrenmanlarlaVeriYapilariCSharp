using System;

namespace dataStructures_homeWork5_Iterative__181180085
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lütfen kaç değerin standart sapmasını bulmak istediğinizi yazınız");
            n = Convert.ToInt32(Console.ReadLine());
            while (n <= 1)
            {
                Console.WriteLine("Girilen sayı birden büyük olmalıdır!!!Lütfen 1'den büyük bir sayı giriniz");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[] dizi = new int[n];
            for (int a = 0; a < n; a++)
            {
                Console.WriteLine("Standart sapması bulunmak istenen {0}. değer", a + 1);
                dizi[a] = Convert.ToInt32(Console.ReadLine());
            }
            double boyut = dizi.Length;
            double toplamsayilar = 0;
            for (int y = 0; y < n; y++)
            {
                toplamsayilar = toplamsayilar + dizi[y];
            }
            double ortalama = toplamsayilar / boyut;
            double toplamFormülündenGelenSayı=0;
            for(int r = 0; r < n; r++)
            {
                toplamFormülündenGelenSayı = toplamFormülündenGelenSayı + Math.Pow((dizi[r] - ortalama), 2);
            }
            double sapma = Math.Sqrt(1 / ((boyut - 1)) * toplamFormülündenGelenSayı);
            Console.WriteLine("Girilen sayıların standart sapması={0}", sapma);
            Console.ReadKey();


        }
    }
}
