using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
	/// <summary>
	/// 抽象创建者
	/// </summary>
	public abstract class BuilderAbstraction
	{
		public abstract void BuilderPartA();

		public abstract void BuilderPartB();

		public abstract Product GetResult();

	}
}
