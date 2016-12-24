using NUnit.Framework;
using System;
using SimpleCalculator;

namespace SimpleCalculator.Test
{
	[TestFixture ()]
	public class SimpleCalculatorTestWithIntegers
	{
		string SUM = "+";
		string SUBSTRUCT = "-";
		string MULTIPLY = "*";
		string DIVIDE = "/";
		string UNKNOWN = "%";

		ICalculator<int> calculator;

		[SetUpAttribute]
		public void Init(){
			calculator = new Calculator<int>();
		}

		[TestCase(2, 3, Result = 5)]
		[TestCase(-2 , 3, Result =  1)]
		[TestCase(0, 2, Result = 2)]
		public int SumTwoIntegersWithSucces (int x, int y)
		{ 
			return calculator.PerformOperation (x, SUM, y);
		}

		[TestCase(2, 3, Result = -1)]
		[TestCase(-2 , 3, Result =  -5)]
		[TestCase(0, 2, Result = -2)]
		public int SubstructTwoIntegersWithSucces (int x, int y)
		{
			return calculator.PerformOperation (x, SUBSTRUCT, y);
		}

		[TestCase(2, 3, Result = 6)]
		[TestCase(-2 , 3, Result =  -6)]
		[TestCase(0, 2, Result = 0)]
		public int MultiplyTwoIntegersWithSucces (int x, int y)
		{
			return calculator.PerformOperation (x, MULTIPLY, y);
		}

		[TestCase(4, 2, Result = 2)]
		[TestCase(-4 , 2, Result =  -2)]
		[TestCase(0, 2, Result = 0)]
		public int DivideTwoIntegersWithSucces (int x, int y)
		{
			return calculator.PerformOperation (x, DIVIDE, y);
		}

		[TestCase(2, 0), ExpectedException(typeof(DivideByZeroException))]
		public void DivedIntByZeroWithException (int x, int y)
		{
			calculator.PerformOperation (x, DIVIDE, y);
		}

		[TestCase(2, 0), ExpectedException(typeof(UnknownOperationException))]
		public void PerformUnknowOperation (int x, int y)
		{
			calculator.PerformOperation (x, UNKNOWN, y);
		}

		[TearDown]
		public void CleanUp()
		{
			calculator = null;	
		}
	}
}

