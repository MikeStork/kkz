using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            //Console.WriteLine("Hello World!");
            //dynamic wynik = test(ReturnType._double);
            //Console.WriteLine(wynik);
            string[] tab = new string[] { "asda" };
            //z2
            double a, b;
            char oper;
            while(true)
            {
                string wczytane = Console.ReadLine();
                if (wczytane != "q")
                {
                    

                    bool isOk = double.TryParse(wczytane, out a);
                    if (!isOk)
                    {
                        Console.WriteLine("nie oke a");
                        continue;
                    }
                    
                    wczytane = Console.ReadLine();
                    bool isOkOp = char.TryParse(wczytane, out oper);
                    if (!isOkOp)
                    {
                        Console.WriteLine("nie oke oper");
                        continue;
                    }
                    
                    wczytane = Console.ReadLine();
                    bool isOk2 = double.TryParse(wczytane, out b);
                    if (!isOk2)
                    {
                        Console.WriteLine("nie oke b");
                        continue;
                    }
                   
                    if(isOk == true && isOk2 == true && isOkOp)
                    {
                        switch (oper)
                        {
                            case '+': Console.WriteLine(a + b); break;
                            case '-': Console.WriteLine(a - b); break;
                            case '/': Console.WriteLine(a / b); break;
                            case '*': Console.WriteLine(a * b); break;
                            case '%': Console.WriteLine(a % b); break;
                            case '=': Console.WriteLine(a == b); break;
                            case '!': Console.WriteLine(a != b); break;
                            case '^': Console.WriteLine(Math.Pow(a,b)); break;
                        }
                        
                    }
                    
                }
                else
                {
                    break;
                }
            }
        }
        
        static dynamic test(ReturnType returnType)
        {
            string tmp = Console.ReadLine();
            switch (returnType)
            {
                case ReturnType._int: return Convert.ToInt32(tmp);
                case ReturnType._double: return Convert.ToDouble(tmp);
                case ReturnType._string: return tmp;
                case ReturnType._bool: return Convert.ToBoolean(tmp);
                default: return null;
            }
        }
        

        enum ReturnType {_int, _double, _string, _bool};
        
    }
}
