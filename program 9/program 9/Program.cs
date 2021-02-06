using System;
using System.Collections.Generic;
using System.Linq;

namespace program_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            //Console.Title = "z3";
            //List<char> spr = new List<char>();
            //char a;
            //while (char.TryParse(Console.ReadLine(), out a))
            //{
            //    if (a != ' ')
            //    {
            //        spr.Add(a);
            //    }

            //}
            //List<char> spr2 = spr.ToList();
            //spr2.Reverse();
            //for (int i = 0; i < spr.Count; i++)
            //{
            //    if (spr[i] == spr2[i])
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("ok  {0} : {1}", spr[i], spr2[i]);

            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("nie ok  {0} : {1}", spr[i], spr2[i]);
            //        return;
            //    }
            //}
            //z1

            //z2
            Console.Title = "z4";
            List<int> AAA = new List<int>();
            for (int i = 2; i <= 50; i++)
            {
                AAA.Add(i);
            }
            for (int j = 0; j < AAA.Count; j++)
            {

                if (AAA[j] != -1)
                {
                    if (AAA[j] > Math.Ceiling(Math.Sqrt(AAA.Count - 1)))
                    {
                        return;
                    }
                    for (int jj = j + 1; jj < AAA.Count; jj++)
                    {
                        if (AAA[jj] % AAA[j] == 0)
                        {
                            AAA[jj] = -1;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
            //z2
            //z3
            //Console.Title = "z1";
            //List<int> An = new List<int>();
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    An.Add((int)Math.Pow(a1, i));
            //}
            //for (int ii = 0; ii < An.Count; ii++)
            //{
            //    Console.WriteLine(An[ii]);
            //}
            //3

            //4
            //List<int[]> pole = new List<int[]>();
            ////int[] tab = new int[] {10,2 };
            ////int[] tab2 = new int[] { 30, 12 };
            ////int[] tab3 = new int[] { 130, 21 };
            ////int[] tab4 = new int[] { 12, 23 };
            //Random r = new Random();
            //for(int k = 0; k<5; k++)
            //{
            //    pole.Add(new int[2]{r.Next(1,50), r.Next(1, 50)});
            //}
            ////pole.Add(tab); pole.Add(tab2); pole.Add(tab3); pole.Add(tab4);
            //int najwpol = 0;
            //int idx = -1;
            //for (int ii = 0; ii < pole.Count; ii++) {
            //    int tmp = pole[ii][0] * pole[ii][1];
            //    if (tmp > najwpol)
            //    {
            //        najwpol = tmp;
            //        idx = ii;
            //    }
            //}
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Title = "z2";

            //Console.WriteLine("\tNajw pole: {0}\t Tablica pod indexem: {1}\t Wartości: {2} i {3}", najwpol, idx, pole[idx][0], pole[idx][1]);
            //4
        }

    }
}
