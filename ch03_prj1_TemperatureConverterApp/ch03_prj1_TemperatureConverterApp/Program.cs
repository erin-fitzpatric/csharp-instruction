using System;

namespace ch03_prj1_TemperatureConverterApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Temperature Converter App!\n");

            string choice = "y";
            while (choice.Equals("y")) {

                Console.Write("Enter degrees in Fahrenheit: ");
                double f = Convert.ToDouble(Console.ReadLine());
                // calcuate conversion
                double degreesC = ((f - 32) * 5 / 9);

                // formula: c = (f - 32) * 5 / 9

               // The application should format the Celsius temperature to allow for up to 2 decimal places.
                    Console.WriteLine("Degrees in celcius: " + Math.Round(degreesC, 2));

                Console.Write("Continue (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Good bye!");
        }
    }
}
