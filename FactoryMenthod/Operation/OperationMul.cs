using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMenthod.Operation
{
	/// <summary>
	/// 乘法运算类
	/// </summary>
	public class OperationMul : OperationSuper
	{
		public override int GetResult(int a, int b)
		{
			return a * b;
		}
	}
}
