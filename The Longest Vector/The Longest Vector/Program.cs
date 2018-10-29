using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Longest_Vector
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcının girmiş olduğu 2 boyutlu uzaydaki 5 nokta ile çizilebilecek en uzun vektörü bulabilen algoritmayı tasarlayınız.

            int[,] koordinatlar = new int[5, 2];
            double max = 0, mesafe = 0;
            double koordinat_x = 0, koordinat_y = 0;
            int x_1 = 0, x_2 = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ". nokta için x koordinatını giriniz : ");
                koordinatlar[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.Write((i + 1) + ". nokta için y koordinatını giriniz : ");
                koordinatlar[i, 1] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                koordinat_x = koordinatlar[i, 0];
                koordinat_y = koordinatlar[i, 1];
                for (int j = 0; j < 5; j++)
                {
                    mesafe = Math.Pow(Math.Pow((koordinat_x - koordinatlar[j, 0]), 2) + Math.Pow((koordinat_y - koordinatlar[j, 1]), 2), 0.5);
                    if (mesafe > max)
                    {
                        max = mesafe;
                        x_1 = i;
                        x_2 = j;
                    }
                }
            }
            Console.WriteLine("Maximum uzunluğa sahip vektör (" + (koordinatlar[x_1, 0]) + "," + (koordinatlar[x_1, 1]) + ") noktası ile (" + (koordinatlar[x_2, 0]) + "," + (koordinatlar[x_2, 1]) + ")noktaları arasında oluşturuldu ve uzunluğu " + max + " birim kadar.");




        }
    }
}
