using System;

namespace DividingBillAtRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //At a restaurant, Mike and his three friends decided to divide the bill evenly. 
            //If each person paid \$13 then what was the total bill?

            int oneThird = 13;
            int totalBill;

            totalBill = oneThird * 3;

            Console.WriteLine("The total bill was " + "$" + totalBill + ".");
        }
    }
}
