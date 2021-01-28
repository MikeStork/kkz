using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = new int[10];
            //for(int i = 0; i< tab.Length; i++)
            //{
            //    tab[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(tab);
            //foreach(int x in tab)
            //{
            //    Console.Write(x+'\t');
            //    Console.Beep(600, 100);
            //}
            int[] tab = new int[100];
            Random rand = new Random();
            for(int i = 0; i<100; i++)
            {
                tab[i] = rand.Next(1, 100);
            }

            int count;
            while (int.TryParse(Console.ReadLine(), out count))
            {
                int findResult = Array.Find<int>(tab, x => x == count);
                if (findResult > 0)
                {
                    Console.WriteLine("Jest");
                }
                else
                {
                    Console.WriteLine("Nie jest");
                }
            }
            int count2;
            while(int.TryParse(Console.ReadLine(), out count2))
            {
                int[] findResult = Array.FindAll<int>(tab, x => x == count2);
                if(findResult.Length > 0)
                {
                    Console.WriteLine("Ilość: " + findResult.Length);
                }
                else
                {
                    Console.WriteLine("Ni mo");
                }
            }

        }
    }
}
