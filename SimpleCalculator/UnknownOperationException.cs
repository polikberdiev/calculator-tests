using System;

namespace SimpleCalculator
{
	public class UnknownOperationException: Exception
	{
		public UnknownOperationException ()
		{
		}

		public UnknownOperationException (string message)
			: base(message)
		{	
		}

		public UnknownOperationException (string message, Exception inner)
			: base(message, inner)
		{	
		}
	}
}

