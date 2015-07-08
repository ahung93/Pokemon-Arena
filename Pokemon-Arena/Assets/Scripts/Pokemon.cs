using UnityEngine;
using System.Collections;

namespace CollectionsApplications
{
	// These should be moved to a different file
	enum Type { Normal, Fighting, Flying, Poison, Ground, Rock, Bug, Ghost, Steel, Fire, Water, Grass, Electric, Psychic, Ice, Dragon, Dark, Fairy, Neutral };
	enum Gender { Male, Female, None };
	enum NonVolatileStatus { Healthy, Burn, Freeze, Paralyze, Sleep, Poison, Toxic, Fainted };
	delegate void fptrMove(Pokemon pokemon);


	public class Pokemon : MonoBehaviour {
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

		private int currentHealth;

		private int maxHealth;

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

		void Update() {
			checkHealth ();
			checkStatus ();
			movePokemon ();
			attackPokemon ();
		}

		public Pokemon() {
			// Figure out how to parse JSON data 
		}

		public void checkHealth(){
			if (currentHealth <= 0) {
				// faint();
				// switchout();
			}
		}

		public void checkStatus(){
			// Checks for paralysis, burn, poison, etc
		}

		public void movePokemon() {
			// Update position and orientation
			// Animation?
		}

		public void attackPokemon() {
			/*
			 *  if move1button == true 
			 *    startCooldown
			 *    lock pokemon movement and animation
			 *    useMove1
			 *  else if move2button == true
			 *    startCooldown
			 *    lock pokemon movement and animation
			 *    useMove2
			 *  else if move3button == true
			 *    startCooldown
			 *    lock pokemon movement and animation
			 *    useMove3
			 *  else if move4button == true
			 *    startCooldown
			 *    lock pokemon movement and animation
			 *    useMove4
			 */ 
		}



		// Change to coroutines (Function that actions over several updates)
		public void useMove1(){
			if (moves[0] != null)
				moves[0] (this);
		}

		public void useMove2(){
			if (moves[1] != null)
				moves[1] (this);
		}

		public void useMove3(){
			if (moves[2] != null)
				moves[2] (this);
		}

		public void useMove4(){
			if (moves[3] != null)
				moves[3] (this);
		}
	}
}