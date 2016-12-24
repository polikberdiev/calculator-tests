using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
	public class Calculator<T>: ICalculator<T> 
	{
		Dictionary<string, Func<T, T, T>> operations = new Dictionary<string, Func<T, T, T>>();

		public Calculator()
		{
			operations.Add ("+", (x, y) => (dynamic)x + (dynamic)y);
			operations.Add ("-", (x, y) => (dynamic)x - (dynamic)y);
			operations.Add ("*", (x, y) => (dynamic)x * (dynamic)y);
			operations.Add ("/", (x, y) => (dynamic)x / (dynamic)y);
		}

		public T PerformOperation(T x, string op, T y)
		{
			if (operations.ContainsKey (op)) {
				return operations [op] (x, y);
			} else {
				throw new UnknownOperationException ("Can not perform operation: " + op);
			}
		}
	}
}
