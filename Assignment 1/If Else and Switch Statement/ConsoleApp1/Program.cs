using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//if_else_statement();
			switch_statement();
			Console.Read();
		}
		static void if_else_statement()
		{
			Console.Write("Enter Your Age: ");
			int n = Convert.ToInt32(Console.ReadLine());

			if (n > 0 && n < 13)
			{
				Console.WriteLine("You are child");
			}
			else if (n >= 13 && n < 18)
			{
				Console.WriteLine("You are teenager");
			}
			else if (n >= 18 && n <= 40)
			{
				Console.WriteLine("You are Adult");
			}
			else if (n > 40 && n <= 60)
			{
				Console.WriteLine("You are middle age man");
			}
			else if (n > 60 && n <= 100)
			{
				Console.WriteLine("You are a Senior Citizen");
			}
			else
			{
				Console.WriteLine("Please Enter your age b/w 1 to 100 only");
			}
		}

		static void switch_statement()
		{
			Console.Write("Enter a number b/w 1 to 8 to check name of the planet position of our solar system: ");
			int n = Convert.ToInt32(Console.ReadLine());

			switch (n)
			{
				case 1:
					Console.WriteLine("Mercury");
					break;

				case 2:
					Console.WriteLine("Venus");
					break;
				case 3:
					Console.WriteLine("Earth");
					break;
				case 4:
					Console.WriteLine("Mars");
					break;
				case 5:
					Console.WriteLine("Jupiter");
					break;
				case 6:
					Console.WriteLine("Saturn");
					break;
				case 7:
					Console.WriteLine("Uranus");
					break;
				case 8:
					Console.WriteLine("Neptune");
					break;
				case 9:
					Console.WriteLine("Pluto");
					break;
				default:
					Console.WriteLine("Please Enter number b/w 1 to 9");
					break;

			}
		}
	}
}
