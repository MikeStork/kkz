using System;

namespace program5
{
    class Program
    {
        static void Main(string[] args)
        {
            int wsk = 0;
            int[] tab = new int[100];
            int[] idx = new int[100];
            Array.Fill<int>(idx, -1);
            Random r = new Random();
            for(int i = 0; i<tab.Length; i++)
            {
                tab[i] = r.Next(0, 100);
            }
            int szukane = Convert.ToInt32(Console.ReadLine());
            //na piechotę
            for(int j= 0; j < tab.Length; j++)
            {
                if (tab[j] == szukane)
                {
                    idx[wsk] = j;
                    wsk++;
                }
            }
        }
    }
}
