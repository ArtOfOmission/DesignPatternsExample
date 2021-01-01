using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMenthod.Operation
{
	/// <summary>
	/// 减法运算类
	/// </summary>
	public class OpeartionSub : OperationSuper
	{
		public override int GetResult(int a, int b)
		{
			return a - b;
		}
	}
}
