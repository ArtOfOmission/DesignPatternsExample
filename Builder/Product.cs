using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
	/// <summary>
	/// 产品
	/// </summary>
	public class Product
	{
		IList<string> parts = new List<string>();

		//添加产品部件
		public void Add(string part)
		{
			parts.Add(part);
		}

		public void Show()
		{
			Console.WriteLine("\n产品 创建------");
			foreach (var item in parts)
			{
				Console.WriteLine(item);
			}
		}

	}
}
