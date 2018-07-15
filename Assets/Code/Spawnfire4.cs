using UnityEngine;
using System.Collections;

public class Spawnfire4 : MonoBehaviour {
	
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
			transform.position = new Vector3 (-5f, 0.42f, -6.5f); 											// MOVE FIRE1 OU
			
			
			Vector3 movefire5in = new Vector3 (0f, 0.18f, -6.5f);
			fire5.transform.position = movefire5in;					 											//MOVE FIRE5 IN
			
			iscreated = false; 
			
			if (!iscreated) 
			{
				
				timerstart = true;
			}
			
		}
	}
	
	
	void Update()
	{
		if (timerstart) 				// IF TIMER IS TRUE START TIMER
		{
			timer += Time.deltaTime; //sets timer in realtime
		}
		
		if (timer > timerlimit) 
			
		{																				// IF TIMER REACHES TIMERLIMIT {
			
			timer = 0.0f;
			timerstart = false;
			
			Debug.Log ("Reached!");
			
			transform.position = new Vector3 (0f, 0.42f, -6.5f); 								// MOVES FIRE 1 BACK INTO GAME
			
			Vector3 movefire5out = new Vector3 (6f, 0.42f, -6.5f); 										// MOVES FIRE5 CLONE OUT OF THE GAME
			fire5.transform.position = movefire5out;
			
		}
		
		if (fire5.transform.position == new Vector3 (-6f, 0.42f, -6.5f)) 
		{
			
			timer = 0.0f;
			timerstart = false;
			
		}
		
		if (fire5.transform.position == new Vector3 (0f, 0.18f, -6.5f)) 
		{
			
			timerstart = true;
			
		}
		
		
		
		
	}
}




















