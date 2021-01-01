using FactoryMethod.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
{
	/// <summary>
	/// 减法工厂
	/// </summary>
	public class SubFactory : IFactory
	{
		public OperationSuper CreateOperation()
		{
			return new OperationSub();
		}
	}
}
