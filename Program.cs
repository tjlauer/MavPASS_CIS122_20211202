//Bush
//Sep 11
//MAv Pass

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211202
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Shelter aShelter = new Shelter();

			

			for (int i = 0; i < 5; i++)
			{
				aShelter.AddToShelter(new Pet("Cat", "whocares",i, "alsowohocares", "young"));
			}
			for (int i = 0; i < 5; i++)
			{
				aShelter.AddToShelter(new Pet("Dog", "whocares", (i+5), "alsowohocares", "young"));
			}

			Console.WriteLine(aShelter);
		}
	}
}
