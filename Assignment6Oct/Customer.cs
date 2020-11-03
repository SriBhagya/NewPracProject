using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Oct
{
	class Customer
	{
		class Constructor
		{
			static string CName;
			int CId;
			int CAge;
			int CPh;
			string City;
			internal Constructor()
			{
				Console.WriteLine("Default constructor");
			}
			internal Constructor(string CName,int CId, int CAge,int CPh,string city)
			{
				this.CId = CId;
				this.CAge = CAge;
				this.CPh = CPh;
				this.City = City;

			}
			internal void Display()
			{
				Console.WriteLine("CName:{0}||CId:{1}||CAge:{2}||CPh:{3}||City:{4}", CName, CId, CAge, CPh, City);
			}
			static void Main()
			{
				Console.WriteLine("enter CName");
				string name = Console.ReadLine();
				Console.WriteLine("enter CId");
				int CId = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter CAge");
				int CAge = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter CPh");
				int CPh = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter City");
				string City = Console.ReadLine();

				Constructor c = new Constructor();
				Constructor cont = new Constructor(CName, CId, CAge, CPh, City);
				cont.Display();
				Console.ReadLine();



			}

		}
		
	}
}
