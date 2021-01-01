using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFacroty.Operation
{
	/// <summary>
	/// 减法运算类
	/// </summary>
	public class OperationSub : OperationSuper
	{
		public override int GetResult(int a, int b)
		{
			return a - b;
		}
	}
}
