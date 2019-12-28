using System;
namespace dataStructures_homework_5_recursive__181180085
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lütfen kaç değerin standart sapmasını bulmak istediğinizi yazınız");
            n = Convert.ToInt32(Console.ReadLine());
            while(n <= 1)
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
            double sapma = Math.Sqrt((1 / ((boyut - 1)) * toplamFormülü( boyut, dizi, ortalama)));
            Console.WriteLine("Girilen sayıların standart sapması={0}", sapma);
            Console.ReadKey();

        }

        static double toplamFormülü(double boyut, int[] dizi, double ortalama)
        {
            if (boyut == 0)
                return 0;
            else
                return (Math.Pow((dizi[Convert.ToInt32(boyut) - 1] - ortalama), 2)) + (toplamFormülü(boyut - 1, dizi, ortalama));

        }
    }
}