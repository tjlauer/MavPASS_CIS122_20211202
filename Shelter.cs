// written by Sungjae

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211202
{
	
	public class Shelter
	{

		// variable
		private List<Pet> listOfPets = new List<Pet>();


		// props
		public List<Pet> ListOfPets 
		{
			get { return this.listOfPets; }
			set { this.listOfPets = value; }

		}

		// Constructors

		public Shelter()
		{

		}

		// Methods

		public override string ToString()
		{
			string message = "";
			foreach(Pet p in ListOfPets)
			{
				message += p.ToString();
			}
			return message;
		}

		public void AddToShelter(Pet p)
		{
			ListOfPets.Add(p);
		}

		public List<Pet> SearchBySpecies(string aSpecies)
		{
			List<Pet> aListOfPets = new List<Pet>();
			foreach(Pet p in ListOfPets)
			{
				if(p.Species == aSpecies)
				{
					aListOfPets.Add(p);
				}
			}
			return aListOfPets;
		}

		public List<Pet> SearchByAge(string anAge)
		{
			List<Pet> aListOfPets = new List<Pet>();
			foreach (Pet p in ListOfPets)
			{
				if (p.Age == anAge)
				{
					aListOfPets.Add(p);
				}
			}
			return aListOfPets;
		}

		public List<Pet> SearchByBreed(string aBreed)
		{
			List<Pet> aListOfPets = new List<Pet>();
			foreach (Pet p in ListOfPets)
			{
				if (p.Age == aBreed)
				{
					aListOfPets.Add(p);
				}
			}
			return aListOfPets;
		}


	}
}
