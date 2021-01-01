using FactoryMethod.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
{
	/// <summary>
	/// 除法工厂
	/// </summary>
	public class DivFactory : IFactory
	{
		public OperationSuper CreateOperation()
		{
			return new OperationDiv();
		}
	}
}
