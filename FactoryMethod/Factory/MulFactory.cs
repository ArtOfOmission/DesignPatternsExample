using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
{
	/// <summary>
	/// 乘法工厂
	/// </summary>
	public class MulFactory : IFactory
	{
		public OperationSuper CreateOperation()
		{
			throw new NotImplementedException();
		}
	}
}
