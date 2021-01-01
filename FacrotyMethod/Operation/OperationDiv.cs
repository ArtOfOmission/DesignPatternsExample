using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFacroty.Operation
{
	/// <summary>
	/// 除法运算类
	/// </summary>
	public class OperationDiv : OperationSuper
	{
		public override int GetResult(int a, int b)
		{
			if (b == 0) throw new DivideByZeroException();
			return a / b;
		}
	}
}
