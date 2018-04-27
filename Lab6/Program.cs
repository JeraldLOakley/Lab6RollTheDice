using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Program
	{
		static void Main(string[] args)
		{
			Welcome();
			TryYourLuck();
		}


		static void Welcome()
		{
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("\t\t\t\t    BACK ALLEY");
			Console.WriteLine("\t\t\t\t =================");
			Console.WriteLine("\t\t\t\t    Dice ROLL");
			Console.WriteLine("\t\t\t\t =================");
			Console.WriteLine();
		}

		static void TryYourLuck()
		{
			while (true)
			{
				Console.WriteLine("\t    Would you like to try your luck at a game of dice? Yes/No");
				Console.Write("\t\t\t\t\t");
				string play = Console.ReadLine().ToUpper();
				if (play == "YES")
				{
					Rolling();
					Console.WriteLine("\t\t\t\t  Have a nice day!");
					return;
				}
				else if (play == "NO")
				{
					return;
				}
				else
				{
					Console.WriteLine("\t\t   I'm sorry I didn't understand your answer");
					Console.WriteLine();
				}
			}
		}

		static void Rolling()
		{
			Console.WriteLine("\t\t\t   Alrighty then, place your bets!");
			while (true)
			{
				//Console.WriteLine("Alrighty then, place your bets!");
				Console.WriteLine("\t\t    Please choose the size dice you wish to roll");
				Console.Write("\t\t\t\t\t");
				string input = Console.ReadLine();
				Console.WriteLine();
				bool success = int.TryParse(input, out int num);
				Random dice = new Random();
				if (success)
				{
					int roll = dice.Next(1, num);
					int roll2 = dice.Next(1, num);
					Console.WriteLine($"\t\t\t    Your first roll got you a(n) \n\t\t\t\t\t {roll} \n \t\t\t\tand the second was a(n)\n \t\t\t\t\t {roll2}");
					Console.WriteLine();
					Console.WriteLine("\t\t   Would you like to try your hand again? Yes or No?");
					Console.Write("\t\t\t\t\t");
					string again = Console.ReadLine().ToUpper();
					if (again == "YES")
					{
						continue;
					}
					else if (again == "NO")
					{
						return;
					}
					else
					{

					}
				}
				else
				{
					Console.WriteLine("\t\t  Aint never heard of that kind of dice,try again");
				}
			}
		}
	}
}
