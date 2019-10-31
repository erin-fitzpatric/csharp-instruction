using System;

namespace ch02_prj1_StudentRegistrationApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Student Registration App!");

            Console.Write("\nEnter First Name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter Year of Birth: ");
            string birthYear = Console.ReadLine();
            int bYear = Convert.ToInt32(birthYear);

            Console.WriteLine("\nWelcome " + fName + " " + lName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + fName + "*" + birthYear);
        }
    }
}
