using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
	class Pen
	{
		public string brand;
		internal string color;
		//constructor
		internal Pen(string b,string color)
		{
			brand = b;
			//refers to current class instance
			this.color = color;
		}
		internal void DisplayPen()
		{
			Console.WriteLine("Brand:{0}||color:{0}", brand, color);

		}
	}
	class ConstructorEg
	{
		static void Main()
		{
			Pen pen = new Pen("parker","blue");
			//pen.brand = "Parker";
			//pen.color = "blue";

			pen.DisplayPen();
			Console.Read();
        }
	}
}
