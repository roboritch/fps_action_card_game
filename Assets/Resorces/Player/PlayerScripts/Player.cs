using UnityEngine;
using System.Collections;

public class Player :  MonoBehaviour , IDamageable{
	[SerializeField]
	[Range(0, 100)]private float health;
	[SerializeField]
	[Range(0, 100)]private float energy;
	[SerializeField]
	[Range(0, 100)]private float procesingPower;

	/// <summary>
	/// Damage the player a specified amount.
	/// </summary>
	/// <param name="amount">Amount.</param>
	/// <returns>True if this object was damaged</returns>
	public bool takeDamage(float amount){
		
		return true;
	}


	// Use this for initialization
	void Start(){
	 
	}
	
	// Update is called once per frame
	void Update(){
	
	}
}

