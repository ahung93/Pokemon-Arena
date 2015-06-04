using UnityEngine;
using System.Collections;

namespace CollectionsApplications
{
	abstract class Pokemon {

		// May need to modify to include other status
		private enum NonVolatileStatus { Burn, Freeze, Paralyze, Sleep, Poison, Toxic };

		// Implement IVs
		private Hashtable ivs;

		// Implement EVs
		private Hashtable evs;

		// Implement Status Buffs/Debuffs

		private Hashtable stats;
		// Figure out function pointers for Move 1
		// 									Move 2
		//									Move 3
		//									Move 4
	}
}