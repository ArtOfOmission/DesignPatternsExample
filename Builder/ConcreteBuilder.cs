using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
	/// <summary>
	/// 具体创建者
	/// </summary>
	public class ConcreteBuilder : BuilderAbstraction
	{
		private Product product = new Product();

		public override void BuilderPartA()
		{
			product.Add("部件A");
		}

		public override void BuilderPartB()
		{
			product.Add("部件B");
		}

		public override Product GetResult()
		{
			return product;
		}

	}
}
