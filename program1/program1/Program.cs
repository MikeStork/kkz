using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[10][];
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = new int[10];
            }
            for (int j = 0; j < 10; j++)
            {
                for(int i = 0; i < 10; i++)
                {
                    tab[i][j] = (i + 1) * (j + 1);
                }
            }
            for (int j = 0; j < tab.Length; j++)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.Write(tab[j][i] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
