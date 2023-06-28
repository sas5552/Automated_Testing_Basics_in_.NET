using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int count = 0;
                int res = 0;
                string[] a = Environment.GetCommandLineArgs();
                char[] arg = a[1].ToCharArray();

                for (int i = 0; i < arg.Length - 1; i++)
                {
                    if (arg[i] != arg[i + 1])
                    {
                        ++count;
                    }
                    else
                    {
                        if (count >= res)
                        {
                            res = count;
                            count = 1;
                        }
                    }
                }
                Console.WriteLine($"Res: {res}");
            }
            else
            {
                Console.WriteLine("Not args");
            }
        }
    }
}

