using System;

/// <summary>
/// 生成器模式（）
/// </summary>
namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			Director director = new Director();

			BuilderAbstraction builder1 = new ConcreteBuilder();

			director.Construct(builder1);

			Product product = builder1.GetResult();

			product.Show();

		}
	}

	/// <summary>
	/// 指挥者
	/// </summary>
	public class Director
	{
		public void Construct(BuilderAbstraction builder)
		{
			builder.BuilderPartA();
			builder.BuilderPartB();
		}
	}

}
