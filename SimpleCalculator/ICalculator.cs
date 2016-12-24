using System;

namespace SimpleCalculator
{
	public interface ICalculator<T>
	{
		T PerformOperation(T x, string op, T y);
	}
}

