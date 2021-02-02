using System;

namespace program7
{
    class Program
    {
        static void Main(string[] args)
        {
            //    bool isOk = true;
            //    string wynik = isOk ? "Podane liczby tworzą ciąg" : "Podane liczby nie tworzą ciągu";
            //    int[] tab = new int[5];
            //    int length = tab.Length;
            //    for (int i = 0; i < length; i++)
            //    {
            //        tab[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Array.Sort(tab);
            //    int diff = tab[1] - tab[0];
            //    for (int i = 2; i < length) ;
            //    Console.WriteLine(wynik);
            //}

            //Random rand = new Random();

            //double[][] troj = new double[10][];
            //for (int i = 0; i < troj.Length; i++)
            //{
            //    troj[i] = new double[3];
            //    for (int j = 0; j < troj[i].Length; j++)
            //    {
            //        troj[i][j] = rand.NextDouble()*10;
            //    }
            //}

            //for (int i = 0; i < troj.Length; i++)
            //{
            //    Console.WriteLine(Math.Sqrt(((troj[i][0] + troj[i][1] + troj[i][2]) / 2) * ((troj[i][0] + troj[i][1] + troj[i][2]) / 2) - troj[i][0] * ((troj[i][0] + troj[i][1] + troj[i][2]) / 2) - troj[i][1] * ((troj[i][0] + troj[i][1] + troj[i][2]) / 2) - troj[i][2]));
            //}
            //foreach(double[] x in troj)
            //{
            //    foreach (double a in x)
            //    {
            //        Console.Write("{0} \t",a);
            //    }
            //    Console.WriteLine();
            //}
            //z1
            //int[,] tab = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //for (int i = 2; i > -1; i--)
            //{
            //    for (int j = 2; j > -1; j--)
            //    {
            //        Console.WriteLine(tab[i,j]);
            //    }
            //}
            //z2
            //int n = Convert.ToInt32(Console.ReadLine());
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double[] tabarg = new double[3] { a, b, c };
            //double[] tab = new double[n * 3];
            //for (int j = 0; j < tab.Length; j++)
            //{
            //    for (double i = 2; i <= n; i++)
            //    {
            //        for (int k = 0; k < tabarg.Length; k++)
            //            tab[j] = Math.Pow(tabarg[k], i);


            //    }
            //    Console.WriteLine(tab[j]);
            //}


            ////3
            //int[] tab = new int[6];
            //Random r = new Random();
            //int i = 0;
            //int a;

            //while (i < tab.Length)
            //{
            //    a = r.Next(1, 49);
            //    int wyn = Array.IndexOf(tab, a);
            //    if (wyn == -1)
            //    {
            //        Console.Beep(440, 250);
            //        Console.WriteLine(a);
            //        tab[i] = a;
            //        i++;
            //    }
            //}
            //Console.WriteLine("Wpisz swoje liczby: ");
            //int trafiles = 6;
            //for (int x = 0; x < 6; x++)
            //{
            //    int h = Convert.ToInt32(Console.ReadLine());
            //    Console.Beep(440, 125);
            //    Console.Beep(756, 125);
            //    int d = Array.IndexOf(tab, h);
            //    if (d == -1)
            //    {
            //        trafiles--;
            //    }
            //}
            //Console.WriteLine("Trafiłeś: {0}!", trafiles);
            //Console.Beep(440, 250);
            //Console.Beep(556, 125);
            //Console.Beep(656, 125);
            //Console.Beep(440, 250);

            //z4
            //Random r = new Random();
            //int[] tab = new int[100];
            //for(int i = 0; i<tab.Length; i++)
            //{
            //    tab[i] = r.Next(-50, 50);
            //}
            //int[] x = Array.FindAll(tab, x => x > 0);
            //int[] y = Array.FindAll(tab, y => y < 0);
            //int[] z = Array.FindAll(tab, z => z % 2 == 0);
            //int[] w = Array.FindAll(tab, w => w % 2 != 0);
            //Console.WriteLine("Dodatnich: {0} \t Ujemnych: {1} \t Parzystych: {2} \t Nieparzyste: {3}", x.Length, y.Length, z.Length, w.Length);

            //z5
            //Random r = new Random();
            //int[] tab = new int[100];
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = r.Next(1, 100);
            //}
            //for (int j = 0; j < tab.Length; j++)
            //{
            //    int[] x = Array.FindAll(tab, x => x == tab[j]);
            //    if (x.Length == 1)
            //    {
            //        Console.WriteLine("Raz wystąpiło: {0}", x[0]);
            //    }
            //}

            //z6
            //Random r = new Random();
            //int[] tab = new int[100];
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = r.Next(1, 100);
            //}
            //int wyniknajw = 0;
            //int wyniktmp = 0;
            //for (int j = 0; j < tab.Length - 1; j++)
            //{
            //    if (tab[j] < tab[j + 1])
            //    {
            //        wyniktmp++;
            //        if (wyniknajw < wyniktmp)
            //        {
            //            wyniknajw = wyniktmp;
            //        }
            //    }
            //    else
            //    {
            //        wyniktmp = 0;
            //    }
            //}
            //Console.WriteLine(wyniknajw);
        }
    }
}
