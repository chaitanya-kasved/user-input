using System;
namespace Program
{
	class Code
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Your Name : "); // Outputing This String.
			string name = Console.ReadLine(); // Taking Input.
			Console.WriteLine("Hello, " + name + "."); // Outputing This String.
					// Taking Input of Numbers.
			Console.WriteLine("Enter Your Age : "); // Outputing This String.
			int age = Convert.ToInt32(Console.ReadLine()); // Taking Input
			Console.WriteLine("Your Age : " + age); // This is string because (string + int = string)
			Console.WriteLine("Your Age After 10 Years : " + (age + 10)); // here (string + (int + int))
		}
	}
}
