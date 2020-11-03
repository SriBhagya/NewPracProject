using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
	class student
	{
		static string collegename;
		string name;
		string dept;

		internal student(string name,string dept)
		{
			this.name = name;
			this.dept = dept;

		}
		internal void DisplayDetails()
		{
			Console.WriteLine("name:{0}||dept:{1}", name, dept);

		}


	}
	class StaticEg
	{
		static void Main()
		{
			string name, dept;
			Console.WriteLine("enter the no. of students");
			int no = Convert.ToInt32(Console.ReadLine());
			student[] student = new student[no];
			for(int i=0;i<student.Length;i++)
			{
				Console.WriteLine("enter the name and dept");
				name = Console.ReadLine();
				dept = Console.ReadLine();
				student[i] = new student(name, dept);


			}
			for(int i=0;i<no;i++)
			{
				student[i].DisplayDetails();

			}
			Console.ReadLine();
		}
	}
}
