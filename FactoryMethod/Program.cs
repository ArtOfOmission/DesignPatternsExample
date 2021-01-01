using FactoryMethod.Factory;
using System;

/// <summary>
/// 工厂方法
/// </summary>
namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			IFactory factory = new AddFactory();

			OperationSuper operation = factory.CreateOperation();
			int r = operation.GetResult(123, 345);


			Console.WriteLine("计算结果是：" + r);
		}
	}
}
