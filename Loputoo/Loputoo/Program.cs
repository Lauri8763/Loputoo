using System;

namespace Loputoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Num();
            RangeNum();
            Countries();
            NumList();
            Object();
        }

        // Max punkt
        public static void Num()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Max Punkt");
            Console.ForegroundColor = ConsoleColor.White;
            byte num1 = 228, num2 = 255;
            decimal num3 = 9128M, num4 = 309M;
            double num5 = 1.2345, num6 = 1.23456;
            long num7 = 1000032000, num8 = 200001200000;
            short num9 = -154, num10 = -182;
            Console.WriteLine("Maksimum siin on = " + Math.Max(num1, num2));
            Console.WriteLine("Maksimum siin on = " + Math.Max(num3, num4));
            Console.WriteLine("Maksimum siin on = " + Math.Max(num5, num6));
            Console.WriteLine("Maksimum siin on = " + Math.Max(num7, num8));
            Console.WriteLine("Maksimum siin on = " + Math.Max(num9, num10));
        }

        // Range punkt
        public static void RangeNum()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Range Punkt");
            Console.ForegroundColor = ConsoleColor.White;
            var numbers = new int[] { 1, 13, 31, 76, 49, 100 };

            var list = numbers.ToList();

            var resultList = list.GetRange(0, 3);

            var result = resultList.ToArray();

            Console.WriteLine(string.Join(" ", result));
        }

        // TakeWhile punkt
        public static void Countries()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TakeWhile Punkt");
            Console.ForegroundColor = ConsoleColor.White;
            IList<string> countryList = new List<string>()
        {
        "Canada",
        "USA",
        "Estonia",
        "Brazil",
        "Finland",
        };
            var result = countryList.TakeWhile(s => s.Length > 4);

            foreach (string str in result)
                Console.WriteLine(str);
        }

        // Except punkt
        public static void NumList()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Except Punkt");
            Console.ForegroundColor = ConsoleColor.White;
            IList<string> numList1 = new List<string>() { "36", "18", "48", "11", "22" };
            IList<string> numList2 = new List<string>() { "44", "103", "11", "36", "88" };

            var result = numList2.Except(numList1);

            foreach (string str in result)
                Console.WriteLine(str);
        }

        // Püramiid punkt 
        public static void Object()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Püramiid Punkt");
            Console.ForegroundColor = ConsoleColor.White;
            int i, j, spc, rows, k, t = 1;

            rows = 4;
            spc = rows + 4;
            for (i = 0; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;
            }
        }
    }
}
