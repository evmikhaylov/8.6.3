using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> numbers = new HashSet<int>();

			Console.WriteLine("Вводите числа");			
			while (true)
			{
				int number = Int32.Parse(Console.ReadLine());
				if (numbers.Contains(number))
					Console.WriteLine("Число уже вводилось ранее");
				else
				{
					numbers.Add(number);
                    Console.WriteLine("Число сохранено");
                }
                
			}
		}
	}
}
