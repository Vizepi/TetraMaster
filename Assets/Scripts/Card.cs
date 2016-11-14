using UnityEngine;
using System.Collections;

/** Card informations
 */
public class Card {

	public class CardManager {
		
		public CardManager() {
			//TODO : Load card file
		}

	}

	private static CardManager manager;

	// Enumerate all types of card
	public enum CardType {
		PHYSIC = 0,
		MAGIC = 1,
		BREAKER = 2,
		DESTROYER = 3
	}

	// Constructors
	public Card(string name) {
		
	}

	// Card identifier
	private long		ID;
	private int			identity;

	// Caracteristics of the card
	private byte		power;
	private CardType	type;
	private byte		physicalDefense;
	private byte		magicalDefense;

	// Represent the current caracteristics of the card.
	// Each fight, this caracterics can be updated and when
	// reaching a given value, update the public caracteristic.
	private byte		internal_power;
	private byte		internal_physicalDefense;
	private byte		internal_magicalDefense;

	// Accumulate the number of attacks, physical defense and amgical defense.
	// This is used to determine the chance of evolution of the card
	private short		accumulator_power;
	private short		accumulator_physicalDefense;
	private short		accumulator_magicalDefense;

	// Accessors
	public static CardManager Manager {
		get {
			return manager;
		}
	}
	public byte Power {
		get {
			return power;
		}
	}
	public CardType Type {
		get {
			return type;
		}
	}
	public byte PhysicDef {
		get {
			return physicalDefense;
		}
	}
	public byte MagicDef
	{
		get
		{
			return magicalDefense;
		}
	}



}
