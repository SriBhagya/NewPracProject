using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
	class Out_ParamsEg
	{
		void Calculation(float n1,float n2,int l,out float s,out float p,out int c)
		{
			s = n1 + n2;//float
			p = n1 * n2;//float
			c = l + 2 * 4;//int

		}
		void Studentdetails(string name, params string[] hobbies)
		{
			Console.WriteLine("name:({0}", name);
			for(int i=0;i<hobbies.Length;i++)
			{
				Console.WriteLine(hobbies[i]);

			}
		}
		static void Main()
		{
			//out parameter
			float num1 = 10, num2 = 80, sum = 0, product = 0;
			int length = 10, cal = 0;
			Out_ParamsEg obj = new Out_ParamsEg();
			obj.Calculation(num1, num2, length, out sum, out product, out cal);
			if(sum>0 && product>0)
				{
				Console.WriteLine("sum:{0}|| product:{0}|| cal{2}", sum, product, cal);

			}
			Console.WriteLine("---------------------------------");
			obj.Studentdetails("edward", "singing", "playing", "reading");
			Console.Read();


		}
			
	}
}
