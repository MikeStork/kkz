using System;
namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            string rl = Console.ReadLine();
            int liczba = Int32.Parse(rl);
            //liczba = Convert.ToInt32(rl);
            string newFloat = Console.ReadLine();
            float nowyFloat = (float)Convert.ToDouble(newFloat);
            //z2
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);

            }
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }
            //z3
            int[,] tab2d = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
            for (int i = 0; i < tab2d.GetLength(0); i++)
            {
                for (int ii = 0; ii < tab2d.GetLength(1); ii++)
                    Console.Write(tab2d[i, ii] + "\t");
                Console.WriteLine("");
            }
            //z4
            int[][] tab2dJ = new int[2][];
            tab2dJ[0] = new int[] { 5, 69, 5, -45 };
            tab2dJ[1] = new int[] { -9, 9};
           
            foreach(int [] tmpTab in tab2dJ)
            {
                foreach(int tmp in tmpTab)
                {
                    Console.WriteLine(tmp);
                }
            }
            
            //z5
            int[,] tabliczka = new int[10, 10];
            for (int i = 0; i < tabliczka.GetLength(0); i++)
            {
                for(int ii = 0; ii< tabliczka.GetLength(1);ii++)
                    tabliczka[i, ii] = (i + 1) * (ii + 1);
            }


            //ver 2
            int[][] tab = new int[10][];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = new int[10];
            }
            for (int jj = 0; jj < 10; jj++)
            {
                for (int i = 0; i < 10; i++)
                {
                    tab[i][jj] = (i + 1) * (jj + 1);
                }
            }

            for (int jjj = 0; jjj < tab.Length; jjj++)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.Write(tab[jjj][i] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
