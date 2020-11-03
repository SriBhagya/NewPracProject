using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Oct
{
	class SwapNumbers
	{
		internal void Swap(int a, int b)
		{
			int c = a;
			a = b;
			b = c;
			Console.WriteLine("after swapping a:{0},b:{1}", a, b);
		}
		internal void Swap(string p, string q)
		{
			string r = p;
			p = q;
			q = r;
			Console.WriteLine("after swapping p:{0},q:{1}", p, q);
		}
		class swapping
		{

		}
		static void Main()
		{
			Console.WriteLine("enter number one");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter number one");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter string one");
			string p = (Console.ReadLine());
			Console.WriteLine("enter string one");
			string q = (Console.ReadLine());
			SwapNumbers swapnumbers = new SwapNumbers();
			SwapNumbers swapnumbers1 = new SwapNumbers();
			swapnumbers.Swap(a, b);
			swapnumbers.Swap(p, q);
			Console.ReadLine();




		}
	}
}
