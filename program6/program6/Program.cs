using System;

namespace program6
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            //double dd;
            //double[] tabdd = new double[6];


            //for (int i = 0; i < 6; i++)
            //{
            //    double.TryParse(Console.ReadLine(), out dd);
            //    tabdd[i] = dd;
            //}

            //int j = 0;
            //while (j < tabdd.Length)
            //{
            //    Console.WriteLine(tabdd[j]);
            //    j++;
            //}

            //z2
            //string str = "";
            //string[] tabstr = new string[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    tabstr[i] = Console.ReadLine();

            //}
            //for (int j = 0; j < 5; j++)
            //{

            //    Console.WriteLine(tabstr[j].Length);
            //}
            //z3
            //int[] tabint = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    tabint[i] = r.Next(1, 10);
            //}

            //int[] result = new int[10];
            //result = Array.FindAll<int>(tabint, x => x > 5);
            //foreach(int x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //z4


            //int[] tab = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    tab[i] = r.Next(1, 10);
            //}
            //for (int j = 0; j < tab.Length; j++)
            //{
            //    if (Array.FindAll<int>(tab, x => x == tab[j]).Length > tab.Length / 2)
            //    {
            //        Console.WriteLine("MA ${0}", tab[j]);
            //    }
            //}


            //z5
            int[] tab = new int[] { 10, 20, 30, 40, 50, 60 };
            int szukane = Convert.ToInt32(Console.ReadLine());
            int[] wyniki = Array.FindAll<int>(tab, x => x == szukane);

        }
    }
}
