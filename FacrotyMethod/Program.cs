using FactoryMenthod;
using System;

namespace FacrotyMethod
{
	class Program
	{
		static void Main(string[] args)
		{


			OperationFactory operationFactory = new OperationFactory();

			OperationSuper operation = operationFactory.CreateOperation(OperatorEnum.Devide);

			int result = operation.GetResult(23, 344);

			Console.WriteLine("运算结果是：" + result);

		}
	}
}
