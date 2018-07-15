using UnityEngine;
using System.Collections;

public class Spawnfire3 : MonoBehaviour {
	
	public float timer = 0.0f;
	public float timerlimit = 2.0f;
	public float instantiatefire4 = 0.0f;
	
	public bool iscreated = true; 
	public bool timerstart = false;
	
	public GameObject fire4;   																					 // fire 1 is the biggest fire, fire 4 is the smallest fire
	
	void OnCollisionEnter (Collision col) //sets collision
	{ 
		if (col.gameObject.name == "Icicles(Clone)") 
		{     																									//if fire collides with icicles {
			Destroy (col.gameObject);    																		// destroy icicles
			transform.position = new Vector3 (-4f, 0.42f, -6.5f); 											// MOVE FIRE1 OU
			
			
			Vector3 movefire4in = new Vector3 (-0.071f, 0.106f, -6.5f);
			fire4.transform.position = movefire4in;					 											//MOVE FIRE4 IN
			
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
			
			transform.position = new Vector3 (-0.071f, 0.106f, -6.5f); 								// MOVES FIRE 1 BACK INTO GAME
			
			Vector3 movefire4out = new Vector3 (5f, 0.42f, -6.5f); 										// MOVES FIRE4 CLONE OUT OF THE GAME
			fire4.transform.position = movefire4out;
			
		}
		
		if (fire4.transform.position == new Vector3 (-5f, 0.42f, -6.5f)) 
		{
			
			timer = 0.0f;
			timerstart = false;
			
		}
		
		if (fire4.transform.position == new Vector3 (0f, 0.42f, -6.5f)) 
		{
			
			timerstart = true;
			
		}
		
		
		
		
	}
}




















