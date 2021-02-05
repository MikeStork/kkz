using System;
using System.Collections.Generic;
using System.Linq;

namespace program_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            //Random r = new Random();
            //bool asder = true;
            //bool nowa = true;
            //int losowa = r.Next(1, 100);
            //while (asder == true)
            //{
            //    if (nowa)
            //    {
            //        losowa = r.Next(1, 100);
            //        nowa = false;
            //    }
            //    Console.WriteLine("Wpisz wartość: ");
            //    int text = Convert.ToInt32(Console.ReadLine());
            //    if (losowa > text)
            //    {

            //        Console.WriteLine("Za mała");
            //    }
            //    if (losowa < text)
            //    {

            //        Console.WriteLine("Za duża");
            //    }
            //    if (losowa == text)
            //    {
            //        Console.WriteLine("Zgadłeś!");
            //        Console.WriteLine("Czy grać dalej?");
            //        Console.WriteLine("1) Graj dalej");
            //        Console.WriteLine("2) Zakończ działanie programu");
            //        if (Console.ReadLine() == "2")
            //        {
            //            asder = false;

            //        }
            //        else
            //        {
            //            nowa = true;
            //        }
            //    }

            //}

            //z2
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Gothic picklock";
            bool[] los = new bool[10];
            Random r = new Random();
            for (int i = 0; i < los.Length; i++)
            {
                int a = r.Next(0, 2);
                if (a == 1)
                {
                    los[i] = true;
                }
                else if (a == 0)
                {
                    los[i] = false;
                }
            }
            while (true)
            {
                bool nextpos = true;
                bool otwarcie = false;
                int i;
                for (i = 0; i < los.Length; i++)
                {
                    int pick = Convert.ToInt32(Console.ReadLine());
                    if (pick == 1)
                    {
                        nextpos = true;
                    }
                    else
                    {
                        nextpos = false;

                    }
                    if (nextpos != los[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Od nowa");
                        Console.Beep(542, 250);
                        Console.Beep(542, 150);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else
                    {
                        otwarcie = true;
                        Console.Beep(542, 150);
                        Console.Beep(442, 150);
                    }
                }
                if (i == los.Length && otwarcie)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Udało się");
                    Console.Beep(542, 350);
                    Console.Beep(562, 150);
                    Console.Beep(562, 150);
                    Console.Beep(642, 350);
                    Console.Beep(682, 100);
                    Console.Beep(682, 100);
                    Console.Beep(682, 100);
                    Console.Beep(720, 500);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }

            //List<int> lista = new List<int>() { 1, 2, 3, 4, 5 };

            //bool onList = lista.Any<int>(x=>x==5);
            //bool all = lista.All<int>(x => x < 5);
            //lista.Clear();

            //List<string> lista = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    lista.Add("AA");
            //}
            //string tmp = "";
            //while ((tmp = Console.ReadLine()).Length > 0)
            //{
            //    lista.Add(tmp);
            //}

            //int idx;
            //while ((tmp = Console.ReadLine()).Length > 0)
            //{
            //    idx = Convert.ToInt32(tmp);
            //    try { 
            //    lista.RemoveAt(idx);
            //    }catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
        }
    }
}
