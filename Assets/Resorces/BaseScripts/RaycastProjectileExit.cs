using UnityEngine;
using System.Collections;


public class RaycastProjectileExit : MonoBehaviour{
	public RaycastHit fireWeapon(){
		Ray projectile = new Ray(transform.position, Vector3.up);
		RaycastHit hit;
		Physics.Raycast(projectile, out hit);
		return hit;
	}
}
