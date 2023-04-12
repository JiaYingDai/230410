using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 元組
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// ValueTuple
			// 法1
			(int, string)product = (1, "PC"); // ValueTuple小地方可以用，但用class還是較佳
											// (int, string)可改成var

			Console.WriteLine(product.Item1);
			Console.WriteLine(product.Item2);

			// 法2
			(int id, string name) product1 = (1, "PC");

			Console.WriteLine(product1.id);
			Console.WriteLine(product1.name);

		}
	}
}
