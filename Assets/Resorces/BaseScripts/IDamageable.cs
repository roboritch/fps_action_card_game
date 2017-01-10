using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

/// <summary>
/// an object implements this if it can be damaged
/// </summary>
public interface IDamageable : IEventSystemHandler{
	bool takeDamage(float amount);
}
