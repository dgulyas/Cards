using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			var ex1 = new Exception("1");
			var ex2 = new Exception("2", ex1);
			var ex3 = new Exception("3", ex2);
			var ex4 = new Exception("4", ex3);

			Console.WriteLine(ex4.ToString());

			Console.ReadLine();


		}
	}
}
