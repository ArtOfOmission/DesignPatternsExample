using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFacroty.Operation
{
	/// <summary>
	/// 加法运算类
	/// </summary>
	public class OperationAdd : OperationSuper
	{
		public override int GetResult(int a, int b)
		{
			return a + b;
		}
	}
}
