using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
	class  Movie
	{
		int id;
		string moviename;
		//DateTime year;
		internal Movie(int id, string moviename)
		{
			this.id = id;
			this.moviename = moviename;
			//	this.year = year;
		}
		internal void DisplayMovie()
		{
			Console.WriteLine("id:{0}||Moviename:{1}||year:{2}", id, moviename);

		}
	}
	class ArrayOfObjects
	{
		static void Main()
		{
			Movie movie = new Movie(101, "Dangal");
			movie.DisplayMovie();

			Movie[] mov = new Movie[2];
			mov[0] = new Movie(102, "roja");
			mov[1] = new Movie(102, "boss");

			for(int i=0;i<2;i++)
			{
				mov[i].DisplayMovie();

			}
			Console.ReadLine();
		}
			
	}
}
