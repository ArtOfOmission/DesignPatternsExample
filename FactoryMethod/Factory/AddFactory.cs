using FactoryMethod.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
{
	/// <summary>
	/// 加法工厂
	/// </summary>
	public class AddFactory : IFactory
	{
		public OperationSuper CreateOperation()
		{
			return new OperationAdd();
		}
	}
}
