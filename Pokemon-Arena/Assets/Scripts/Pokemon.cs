using UnityEngine;
using System.Collections;

namespace CollectionsApplications
{
	enum Gender { Male, Female, None };
	enum NonVolatileStatus { Healthy, Burn, Freeze, Paralyze, Sleep, Poison, Toxic, Fainted };
	delegate void fptrMove(Pokemon pokemon);


	class Pokemon {
		private string name;

		private string species;

		private int speciesNum;

		private Gender gender;

		private string[] type;

		private string classification;

		private double height;

		private double weight;

		// Capture Rate
		// Base Egg Steps

		private string ability;

		private int happiness;

		// Base Stats
		private Hashtable stats;

		// Implement IVs
		private Hashtable ivs;

		// Implement EVs
		private Hashtable evs;

		// Implement Status Buffs/Debuffs
	

		// Figure out delegates for Move 1
		// 							Move 2
		//							Move 3
		//							Move 4
		// Make sure that it is the SAME object passed in (or a reference), cannot be a duplicate object
		private fptrMove [] moves;

		private bool mega;

		// May need to modify to include other status

		public Pokemon() {
			// Figure out how to parse JSON data 
		}

		public void useMove1(){
			if (fptrMove[0] != null)
				fptrMove [0] (this);
		}

		public void useMove2(){
			if (fptrMove[1] != null)
				fptrMove [1] (this);
		}

		public void useMove3(){
			if (fptrMove[2] != null)
				fptrMove [2] (this);
		}

		public void useMove4(){
			if (fptrMove[3] != null)
				fptrMove [3] (this);
		}
	}
}