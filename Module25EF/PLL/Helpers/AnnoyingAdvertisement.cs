using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module25EF.PLL.Helpers
{
    public static class AnnoyingAdvertisement
    {
        public static void Show()
        {
            Ad("1xBet - ставки на спорт");
            Thread.Sleep(1000);
            Console.WriteLine();
            Ad("IndigoGo - прокачай свою речь");
            Thread.Sleep(1000);
            Console.WriteLine();
            Ad("Cake - разговорный английский по 10 минут в день");
            Thread.Sleep(1000);
            Console.WriteLine();
        }

        public static void Ad(string adMessage)
        {
            int i = 0;
            foreach (var l in adMessage)
            {
                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(l);
                    Thread.Sleep(100);
                    Console.ResetColor();
                }
                else if (i % 3 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(l);
                    Thread.Sleep(100);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(l);
                    Thread.Sleep(100);
                    Console.ResetColor();
                }
                i++;
            }
        }
    }
}
