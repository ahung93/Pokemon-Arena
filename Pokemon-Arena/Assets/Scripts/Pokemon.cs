using UnityEngine;
using System.Collections;

namespace CollectionsApplications
{
	class Pokemon {

		private string species;
		// May need to modify to include other status
		private enum NonVolatileStatus { Healthy, Burn, Freeze, Paralyze, Sleep, Poison, Toxic, Fainted };

		private enum Gender { Male, Female, None };

		// Implement IVs
		private Hashtable ivs;

		// Implement EVs
		private Hashtable evs;

		// Implement Status Buffs/Debuffs

		private Hashtable stats;

		// Figure out delegates for Move 1
		// 							Move 2
		//							Move 3
		//							Move 4
		// Make sure that it is the SAME object passed in (or a reference), cannot be a duplicate object
		delegate void fptrMove(Pokemon pokemon);

		private fptrMove move1;
		private fptrMove move2;
		private fptrMove move3;
		private fptrMove move4;

		public Pokemon() {
			// Figure out how to parse JSON data 
		}
	}
}