using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace FormattingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //long a = 123456789;

            //Console.WriteLine("{0:E3}", a);
            //Console.WriteLine("{0:X4}", a);

            DateTime date = DateTime.Now;

            //Console.WriteLine("{0:d}", date);
            //Console.WriteLine("{0:D}", date);
            //Console.WriteLine("{0:t}", date);
            //Console.WriteLine("{0:T}", date);
            //Console.WriteLine("{0:y}", date);
            //Console.WriteLine("{0:Y}", date);
            //Console.WriteLine("{0:dd/MM/yyyy}", date);

            //Console.WriteLine("{0:G}", DayOfWeek.Wednesday);
            //Console.WriteLine("{0:D}", DayOfWeek.Wednesday);
            //Console.WriteLine("{0:X}", DayOfWeek.Wednesday);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", date);


        }
    }
}
