using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string a in args)
            {
                if (a.Length > 6)
                {
                    return;
                }

                if (a.Length > 3)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}