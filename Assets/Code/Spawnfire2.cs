  using UnityEngine;
using System.Collections;

public class Spawnfire2 : MonoBehaviour {
	
	public float timer = 0.0f;
	public float timerlimit = 2.0f;
	public float instantiatefire3 = 0.0f;
	
	public bool iscreated = true; 
	public bool timerstart = false;
	
	public GameObject fire3;   																					 // fire 1 is the biggest fire, fire 4 is the smallest fire
	
	void OnCollisionEnter (Collision col) //sets collision
	{ 
		if (col.gameObject.name == "Icicles(Clone)") 
		{     																									//if fire collides with icicles {
			Destroy (col.gameObject);    																		// destroy icicles
			transform.position = new Vector3 (-3f, 0.42f, -6.5f); 											// MOVE FIRE1 OU
			
			
			Vector3 movefire3in = new Vector3 (-0.071f, 0.106f, -6.5f);
			fire3.transform.position = movefire3in;					 											//MOVE FIRE3 IN
			
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
			
			Vector3 movefire3out = new Vector3 (4f, 0.42f, -6.5f); 										// MOVES FIRE3 CLONE OUT OF THE GAME
			fire3.transform.position = movefire3out;
			
		}
		
		if (fire3.transform.position == new Vector3 (-4f, 0.42f, -6.5f))
			 
		{
			
			timer = 0.0f;
			timerstart = false;
			
		}
		
		if (fire3.transform.position == new Vector3 (-0.071f, 0.106f, -6.5f))
		{
			
			timerstart = true;
			
		}
		
		
		
		
	}
}




















