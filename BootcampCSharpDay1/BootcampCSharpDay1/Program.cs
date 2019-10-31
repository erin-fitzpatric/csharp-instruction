using System;

namespace BootcampCSharpDay1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("C# Day 1");

            int a = 5;
            int b = 10;
            int sum = a + b;
            Console.WriteLine("Sum = " + sum);

            string choice = "y";
            /*while (choice.Equals("y")) {
                Console.WriteLine("In a while loop....");
                Console.Write("Choice? ");
                choice = Console.ReadLine();
                Console.WriteLine("choice = " + choice);
            }*/

            if (sum > 10) {
                Console.WriteLine("Sum greater than 10");
            }
            else {
                Console.WriteLine("Sum less than or equal to 10");
            }
/*            Console.WriteLine("Enter a number: ");
            String nbrStr = Console.ReadLine();
            int nbr = Convert.ToInt32(nbrStr);
            Console.WriteLine("nbr = " + nbr);*/

            double d1 = 4.5;
            double d2 = 5.7;
            int sum2 = (int)(d1 + d2);
            double sum3 = d1 + d2;
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);


            Random random = new Random();

            // random number
            int r1 = random.Next();
            Console.WriteLine("r1 = " + r1);

            // random number within range of 10
            int r2 = random.Next(10);
            Console.WriteLine("r2 = " + r2);

            // random number within range of 1 and 10
            while (r2!=10) {
                r2 = random.Next(10);
                r2++;                                                                 
                Console.WriteLine("r2 = " + r2);
            }

            // round decimals
            double d3 = 75.8834222;
            Console.WriteLine("d3 rounded..."+Math.Round(d3));
            Console.WriteLine("d3 rounded to 2 digits..."+Math.Round(d3,2));


            // format as number format and perecent
            double price = 15.99;
            double pct = .03467;

            Console.WriteLine("price formatted: " + price.ToString("C2"));
            Console.WriteLine("pct formatted: " + pct.ToString("P3"));

            Console.WriteLine("Good bye!");
        }
    }
}
