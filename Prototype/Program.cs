using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Book book1 = new Book()
			{
				Name = "幸福",
				Classfication = "文学",
				Publisher = "小白"
			};


			Book bookCopy = (Book)book1.Clone();


			bookCopy.Name = "与时间做朋友";

			bookCopy.Display();

		}
	}


	public class Book:ICloneable
	{

		public Book()
		{

		}

		public void Display() {

			Console.WriteLine("书名:" + this.Name);
			Console.WriteLine("分类:" + this.Classfication);
			Console.WriteLine("出版社:" + this.Publisher);

		}

		/// <summary>
		/// 书名
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 分类
		/// </summary>
		public string  Classfication { get; set; }

		/// <summary>
		/// 出版社
		/// </summary>
		public string Publisher { get; set; }

		public object Clone()
		{
			return (object)this.MemberwiseClone();
		}
	}

}
