using System;

namespace TheWhite_UTest
{
	class Program
	{
		static void Main(string[] args)
		{
			int calcBase = 2;
			var converter = new DecimalNumberConverter(calcBase);

			while (true)
			{
				Console.WriteLine("Введите число:");
				try
				{
					int num = int.Parse(Console.ReadLine());
					var res = converter.Convert(num);
					Console.WriteLine($"{num} в {calcBase} системе:\n{res}\n\n");
				}
				catch (ArgumentException e)
				{
					Console.WriteLine($"Ошибка!\n{e.Message}");
				}
			}
		}
	}
}
