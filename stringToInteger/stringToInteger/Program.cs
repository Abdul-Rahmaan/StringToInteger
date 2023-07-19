using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringToInteger
{
    public class Program
    {
        public static void Main()
        {
            string applesInBasket = "12";
            string baskets = "4";

            int total = Convert.ToInt32(applesInBasket) * Convert.ToInt32(baskets);

            string msg = $"There are total of {total} apples";
            Console.WriteLine(msg);
        }
    }
}
