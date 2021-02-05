using System;
using System.Collections.Generic;

namespace kombinatoryka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            var karty = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 2; j <= 14; j++)
                        {
                            switch (j)
                            {
                                case 11:
                                    karty.Add("♠ " + "J");
                                    break;
                                case 12:
                                    karty.Add("♠ " + "Q");
                                    break;
                                case 13:
                                    karty.Add("♠ " + "K");
                                    break;
                                case 14:
                                    karty.Add("♠ " + "A");
                                    break;

                                default:
                                    karty.Add("♠ " + Convert.ToString(j));
                                    break;

                            }
                        }
                        break;
                    case 1:
                        for (int j = 2; j <= 14; j++)
                        {
                            switch (j)
                            {
                                case 11:
                                    karty.Add("♣ " + "J");
                                    break;
                                case 12:
                                    karty.Add("♣ " + "Q");
                                    break;
                                case 13:
                                    karty.Add("♣ " + "K");
                                    break;
                                case 14:
                                    karty.Add("♣ " + "A");
                                    break;

                                default:
                                    karty.Add("♣ " + Convert.ToString(j));
                                    break;

                            }
                        }
                        break;
                    case 2:
                        for (int j = 2; j <= 14; j++)
                        {
                            switch (j)
                            {
                                case 11:
                                    karty.Add("♥ " + "J");
                                    break;
                                case 12:
                                    karty.Add("♥ " + "Q");
                                    break;
                                case 13:
                                    karty.Add("♥ " + "K");
                                    break;
                                case 14:
                                    karty.Add("♥ " + "A");
                                    break;

                                default:
                                    karty.Add("♥ " + Convert.ToString(j));
                                    break;

                            }
                        }
                        break;
                    case 3:
                        for (int j = 2; j <= 14; j++)
                        {
                            switch (j)
                            {
                                case 11:
                                    karty.Add("♦ " + "J");
                                    break;
                                case 12:
                                    karty.Add("♦ " + "Q");
                                    break;
                                case 13:
                                    karty.Add("♦ " + "K");
                                    break;
                                case 14:
                                    karty.Add("♦ " + "A");
                                    break;

                                default:
                                    karty.Add("♦ " + Convert.ToString(j));
                                    break;

                            }
                        }
                        break;
                }
            }
            for (int i = 0; i < 4; i++)
                for(int j = 0; j<14; j++)
                    Console.Write(karty[i]+"\t");
            Console.WriteLine("");
            
        }
    }
}
