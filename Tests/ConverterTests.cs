using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TheWhite_UTest;

namespace Tests
{
	[TestClass]
	public class ConverterTests
	{
		readonly Random rnd;
		public ConverterTests()
		{
			rnd = new Random((int)DateTime.Now.Ticks);
		}

		[TestMethod]
		public void BynaryTests()
		{
			int sysBase = 2;

			Test(sysBase, 10);
		}

		private void Test(int sysBase, int iterations)
		{
			var myConv = new DecimalNumberConverter(sysBase);
			for (int i = 0; i < iterations; i++)
			{
				int number = rnd.Next(0, 100);
				string expected = Convert.ToString(number, sysBase);

				var actual = myConv.Convert(number);

				actual = actual.ToLower();
				Assert.AreEqual(expected, actual);
			}
		}

		[TestMethod]
		public void HexTests()
		{
			int sysBase = 16;

			Test(sysBase, 10);
		}
	}
}
