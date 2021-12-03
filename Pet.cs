//Nate + MavPPasssss
//Sep 11
//MAv Pass

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211202
{
	public class Pet
	{
		//private variables
		private string species = "";
		private string name = "";
		private int petId = -1;
		private string breed = "";
		private string age = "";

		//props
		public string Species { get { return this.species; } set { this.species = value; } }
		public string Name {  get { return this.name; } set { this.name = value; } }
		public int PetId {  get { return this.petId; } set { this.petId = value; } }
		public string Breed {  get { return this.breed; } set { this.breed = value; } }
		public string Age
		{
			get { return this.age; }
			set
			{
				List<string> okayList = new List<string>() { "baby", "young", "adult", "mature" };
				if (okayList.Contains(value))
				{
					this.age = value;
				}
				else
				{
					// This is where you would do you exception!!!
					this.age = "n/a";
				}
			}
		}

		//constructor
		public Pet(): this("n/a", "n/a",-1, "n/a", "n/a")
		{

		}

		public Pet(string aSpecies, string aName, int aID, string aBreed, string anAge)
		{
			this.Species = aSpecies;
			this.Name = aName;
			this.PetId = aID;
			this.Breed = aBreed;
			this.Age = anAge;


		}

		//methods
		public override string ToString()
		{
			string msg = "";
			msg = msg + $"{this.Species} \n {this.Name} \n {this.PetId} \n {this.Breed} \n {this.Age}";
			return msg;
		}
	}
}
