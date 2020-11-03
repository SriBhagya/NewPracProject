using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Oct
{
	class Product
	{
		string PName;
		int PId;
		int PPrice;
		static string ShopName;


		Product(string PName, int PId,int PPrice,string ShopName)
		{
			this.PName = PName;
			this.PId = PId;
			this.PPrice = PPrice;
		}
		internal void DisplayProductDetails()
		{
			ShopName = "B&B Traders";
			Console.WriteLine("PName:{0}||PId:{1}||PPrice:{2}||ShopName:{3}", PName, PId, PPrice, ShopName);

		}
		static void Main()
		{
			Console.WriteLine("enter size");
			int size = Convert.ToInt32(Console.ReadLine());
			Product[] product = new Product[size];
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine("enter ProductId");
				int Productid = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter Productname");
				string productname = Console.ReadLine();
				Console.WriteLine("enter Productprice");
				int Productprice = Convert.ToInt32(Console.ReadLine());
				product[i] = new Product(PName, PId, PPrice);
			}

			for (int i = 0; i < size; i++)
			{
				product[i].DisplayProductDetails();
			}
			Console.Read();
		}
	}
}
