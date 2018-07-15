using UnityEngine;
using System.Collections;

public class Spawnfire5 : MonoBehaviour {
	
	public float timer = 0.0f;
	public float timerlimit = 2.0f;
	public float instantiatefire5 = 0.0f;
	
	public bool iscreated = true; 
	public bool timerstart = false;
	
	public GameObject fire5;   																					 // fire 1 is the biggest fire, fire 5 is the smallest fire
	
	void OnCollisionEnter (Collision col) //sets collision
	{ 
		if (col.gameObject.name == "Icicles(Clone)") 
		{     																									//if fire collides with icicles {
			Destroy (col.gameObject);    																		// destroy icicles
			transform.position = new Vector3 (-6f, 0.42f, -6.5f); 											// MOVE FIRE1 OU
			
		}
	}
}
	
