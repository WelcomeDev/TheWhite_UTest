using System;
using System.Collections.Generic;
using System.Text;

namespace TheWhite_UTest
{
	public class DecimalNumberConverter
	{
		public const int MaxBase = 36;

		private readonly string items = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public DecimalNumberConverter(int calcBase = 2)
		{
			if (calcBase < 2 || calcBase > MaxBase)
				throw new ArgumentException("Неверное основание системы");

			CalcBase = calcBase;
		}

		public int CalcBase { get; }

		/// <summary>
		/// Переводит положительное число в указаную систему
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public string Convert(int number)
		{
			if (number < 0)
				throw new ArgumentException("Число должно быть положительным!");

			StringBuilder res = new StringBuilder();

			int cur = number;
			while (cur >= CalcBase)
			{
				int div = cur % CalcBase;
				res.Insert(0, items[div]);
				//res.Append(items[div]);
				cur /= CalcBase;
			}

			res.Insert(0, items[cur]);

			return res.ToString();
		}
	}
}
