using FacrotyMethod;
using FactoryMenthod.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMenthod
{
	/// <summary>
	/// 工厂类
	/// </summary>
    public class OperationFactory
	{
		public OperationFactory()
		{

		}

		public OperationSuper CreateOperation(OperatorEnum operatorEnum) {

			if (operatorEnum == OperatorEnum.Add)
			{
				return new OperationAdd();
			}
			else if (operatorEnum == OperatorEnum.Subduce)
			{
				return new OperationSub();
			}
			else if (operatorEnum == OperatorEnum.Multiply)
			{
				return new OperationMul();
			}
			else if (operatorEnum == OperatorEnum.Devide)
			{
				return new OperationDiv();
			}

			return null;
		}
	}
}
